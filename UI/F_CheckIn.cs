using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Data;
using DTO;
using Services;

namespace UI
{
    public partial class F_CheckIn : Form
    {
        private readonly LibraryContext db;
        private readonly CheckInService checkInService;
        private readonly PointsLedgerService pointsService;
        public F_CheckIn() : this(new Data.LibraryContext()) { }

        public F_CheckIn(LibraryContext context)
        {
            InitializeComponent();

            db = context;
            checkInService = new CheckInService(db);
            pointsService = new PointsLedgerService(db);
        }

        private void F_CheckIn_Load(object? sender, EventArgs e)
        {
            txtUserId.Focus();
        }

        private void TxtUserId_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheckIn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BtnCheckIn_Click(object? sender, EventArgs e)
        {
            // 1) Validate UserId
            if (!int.TryParse(txtUserId.Text.Trim(), out var userId) || userId <= 0)
            {
                ShowStatus("Mã người dùng không hợp lệ!", false);
                txtUserId.SelectAll();
                txtUserId.Focus();
                return;
            }

            // 2) Gọi service Check-in
            var note = txtNote.Text.Trim();
            var rs = checkInService.CheckIn(userId, string.IsNullOrEmpty(note) ? null : note);

            ShowStatus(rs.Message, rs.Success);

            // 3) Nếu OK, refresh tổng điểm + lịch sử
            if (rs.Success)
            {
                RefreshSummary(userId);
                txtNote.Clear();
                txtUserId.SelectAll();
                txtUserId.Focus();
            }
        }

        private void RefreshSummary(int userId)
        {
            try
            {
                // Tổng điểm
                var total = pointsService.GetTotalPoints(userId);
                lblTotalPoints.Text = total.ToString();

                // Lịch sử check-in 30 ngày gần nhất
                var from = DateTime.Now.Date.AddDays(-30);
                var list = checkInService.GetByUser(userId, from, null);

                gv.DataSource = null;
                gv.DataSource = list;

                // Đặt header tiếng Việt + format cột
                if (gv.Columns["CheckInId"] != null) gv.Columns["CheckInId"].HeaderText = "Mã";
                if (gv.Columns["UserId"] != null) gv.Columns["UserId"].HeaderText = "Mã người dùng";
                if (gv.Columns["FullName"] != null) gv.Columns["FullName"].HeaderText = "Họ và tên";
                if (gv.Columns["UserName"] != null) gv.Columns["UserName"].HeaderText = "Tài khoản";
                if (gv.Columns["CheckInTime"] != null)
                {
                    gv.Columns["CheckInTime"].HeaderText = "Thời gian";
                    gv.Columns["CheckInTime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
                if (gv.Columns["Note"] != null) gv.Columns["Note"].HeaderText = "Ghi chú";

                gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gv.RowHeadersVisible = false;
                gv.ReadOnly = true;
                gv.AllowUserToAddRows = false;
                gv.AllowUserToDeleteRows = false;
                gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Hiển thị tên user ở label (nếu có)
                var first = list.FirstOrDefault();
                lblUserName.Text = first != null ? $"{first.FullName} ({first.UserName})" : "(chưa có dữ liệu)";
            }
            catch (Exception ex)
            {
                ShowStatus($"Lỗi tải dữ liệu: {ex.Message}", false);
            }
        }

        private void ShowStatus(string message, bool success)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = success ? Color.ForestGreen : Color.IndianRed;
        }
    }
}
