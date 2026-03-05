using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Services;
using Data.Entities;
using DTO;
using Data;
using ClosedXML.Excel;

namespace UI
{
    public partial class F_ViewPointsHistory : Form
    {
        private readonly PointsLedgerService _pointsLedgerService;

        public F_ViewPointsHistory()
        {
            InitializeComponent();
            _pointsLedgerService = new PointsLedgerService(new LibraryContext());
        }

        // Khởi tạo form và tải dữ liệu ban đầu
        private void F_ViewPointsHistory_Load(object sender, EventArgs e)
        {
            dgvPointsHistory.AutoGenerateColumns = false;
            SetupGrid();

            // Đảm bảo các TextBox, DateTimePicker được chuẩn bị
            txtUserId.Text = string.Empty; // Khởi tạo UserId trống
            dtpFrom.Value = DateTime.Now.AddMonths(-1); // Mặc định từ tháng trước
            dtpTo.Value = DateTime.Now; // Đến ngày hiện tại
           

            LoadPointsHistory();
        }

        // Thiết lập DataGridView để hiển thị lịch sử điểm
        private void SetupGrid()
        {
            dgvPointsHistory.Columns.Clear();

            dgvPointsHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LedgerId",
                HeaderText = "Mã lịch sử",
                DataPropertyName = "LedgerId",
                Width = 90
            });

            dgvPointsHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UserId",
                HeaderText = "Mã người dùng",
                DataPropertyName = "UserId",
                Width = 100
            });

            dgvPointsHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Tên người dùng",
                DataPropertyName = "FullName",
                Width = 150
            });

            dgvPointsHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Points",
                HeaderText = "Số điểm",
                DataPropertyName = "Points",
                Width = 100
            });

            dgvPointsHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Reason",
                HeaderText = "Lý do",
                DataPropertyName = "Reason",
                Width = 200
            });

            dgvPointsHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreatedAt",
                HeaderText = "Ngày tạo",
                DataPropertyName = "CreatedAt",
                Width = 150
            });

            dgvPointsHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CheckInTime",
                HeaderText = "Thời gian Check-in",
                DataPropertyName = "CheckInTime",
                Width = 150
            });

            dgvPointsHistory.RowHeadersVisible = false;
            dgvPointsHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPointsHistory.ReadOnly = true;
            dgvPointsHistory.Dock = DockStyle.Fill;  // Đây là quan trọng để DataGridView chiếm hết không gian.
        }

        // Lọc và hiển thị dữ liệu khi nhấn nút tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int userId;
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || !int.TryParse(txtUserId.Text.Trim(), out userId))
            {
                MessageBox.Show("Vui lòng nhập đúng mã người dùng.");
                return;
            }

            DateTime fromDate = dtpFrom.Value;
            DateTime toDate = dtpTo.Value;

            // Lấy lịch sử điểm của người dùng từ dịch vụ
            var pointsHistory = _pointsLedgerService.GetHistory(userId, fromDate, toDate);

            // Hiển thị kết quả lên DataGridView
            dgvPointsHistory.DataSource = pointsHistory;

            // Cập nhật tổng kết quả
            lblTotal.Text = $"Tổng kết quả: {pointsHistory.Count} mục";
        }

        // Lấy dữ liệu lịch sử điểm cho tất cả người dùng
        private void LoadPointsHistory()
        {
            // Lấy tất cả lịch sử điểm từ database (không có lọc)
            // Lấy tất cả lịch sử điểm từ database (không có lọc), sử dụng GetAll()
            var pointsHistory = _pointsLedgerService.GetAll();

            // Hiển thị kết quả lên DataGridView
            dgvPointsHistory.DataSource = pointsHistory;

            // Cập nhật tổng kết quả
            lblTotal.Text = $"Tổng kết quả: {pointsHistory.Count} mục";
        }

        // Sự kiện xuất dữ liệu JSON khi nhấn nút
        private void btnExportJson_Click(object sender, EventArgs e)
        {
            if (dgvPointsHistory.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "JSON|*.json",
                FileName = "History_Points.json"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Lấy dữ liệu từ DataGridView và xuất thành JSON
                var data = (List<PointsLedgerDTO>)dgvPointsHistory.DataSource;
                var json = System.Text.Json.JsonSerializer.Serialize(data, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });

                // Lưu vào file JSON
                System.IO.File.WriteAllText(sfd.FileName, json);
                MessageBox.Show("Xuất dữ liệu thành công!");
            }
        }

        // Đảm bảo form có thể mở rộng và có thể thay đổi kích thước khi ở chế độ full màn hình
        private void F_ViewPointsHistory_Resize(object sender, EventArgs e)
        {
            // Cập nhật kích thước DataGridView để nó chiếm toàn bộ diện tích của form
            dgvPointsHistory.Width = this.ClientSize.Width - 40; // Cộng trừ một chút khoảng cách biên
            dgvPointsHistory.Height = this.ClientSize.Height - pnlSearch.Height - 60; // Cập nhật chiều cao của dgv
        }

        // Đảm bảo Form mở toàn màn hình khi khởi động
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;  // Đảm bảo form mở ở chế độ full màn hình
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvPointsHistory.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel|*.xlsx",
                FileName = "History_Points.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Tạo mới Workbook và Worksheet
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("History Points");

                // Thêm tiêu đề cột
                for (int i = 0; i < dgvPointsHistory.Columns.Count; i++)
                {
                    ws.Cell(1, i + 1).Value = dgvPointsHistory.Columns[i].HeaderText;
                }

                // Thêm dữ liệu từ DataGridView vào worksheet
                for (int i = 0; i < dgvPointsHistory.Rows.Count; i++)
                {
                    // Kiểm tra nếu dòng không phải dòng trống (trường hợp dữ liệu bị thiếu)
                    if (dgvPointsHistory.Rows[i].IsNewRow)
                        continue;

                    for (int j = 0; j < dgvPointsHistory.Columns.Count; j++)
                    {
                        // Dùng toán tử null-conditional để tránh lỗi null
                        var cellValue = dgvPointsHistory.Rows[i].Cells[j]?.Value;

                        // Chỉ thêm giá trị không null vào Excel
                        if (cellValue != null)
                        {
                            ws.Cell(i + 2, j + 1).Value = cellValue.ToString();
                        }
                        else
                        {
                            ws.Cell(i + 2, j + 1).Value = ""; // Nếu dữ liệu trống thì để ô Excel trống
                        }
                    }
                }

                // Lưu file Excel
                wb.SaveAs(sfd.FileName);
                MessageBox.Show("Xuất dữ liệu thành công!");
            }
        }
    }
}
