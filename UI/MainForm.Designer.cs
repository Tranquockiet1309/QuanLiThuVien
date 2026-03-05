using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlSidebar;
        private Panel pnlContent;

        // Buttons
        private Button btnDashboard;
        private Button btnNhanVien;
        private Button btnLoaiSach;
        private Button btnNhaXuatBan;
        private Button btnSach;
        private Button btnTimSach;
        private Button btnTimNhaXB;
        private Button btnMuonsach;
        private Button btnCheckin;
        private Button btnPoint;
        private Button btnThoat;
        private Button btnLogout;
        private Button btnChangePass;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            pnlSidebar = new Panel();
            pnlContent = new Panel();
            btnDashboard = new Button();
            btnNhanVien = new Button();
            btnLoaiSach = new Button();
            btnNhaXuatBan = new Button();
            btnSach = new Button();
            btnMuonsach = new Button();
            btnTimSach = new Button();
            btnTimNhaXB = new Button();
            btnCheckin = new Button();
            btnThoat = new Button();
            btnPoint = new Button();
            btnLogout = new Button();
            btnChangePass = new Button();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();

            SuspendLayout();

            // ========== SIDEBAR ==========
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Width = 250;
            pnlSidebar.BackColor = Color.FromArgb(45, 55, 72);
            pnlSidebar.Padding = new Padding(10);

            // ========== NÚT MENU ==========
            Button[] buttons =
            {
                btnLogout,
                btnChangePass,
                btnThoat  ,// 0
                btnNhanVien,    // 1
                btnLoaiSach,    // 2
                btnNhaXuatBan,  // 3
                btnSach,        // 4
                btnMuonsach,    // 5
                btnTimSach,     // 6
                btnTimNhaXB,    // 7
                btnCheckin,
                btnPoint,
                btnDashboard,  // 8 ⭐
                      // 9
            };

            string[] titles =
            {
                "🔑 Đăng xuất",
                "🔒 Đổi mật khẩu",
                "🚪 Thoát",
                "👨 Nhân viên",
                "📚 Loại sách",
                "🏢 Nhà xuất bản",
                "📖 Sách",
                "📚 Mượn sách",
                "🔍 Tìm sách",
                "🏷️ Tìm NXB - Loại sách",
                "⏱️ Check-in",
                "⏱️ Điểm rèn luyện ",
                "🏠 Dashboard",
            };

            EventHandler[] handlers =
            {
                mnuLogout_Click, // 0
                mnuChangePass_Click,
                mnuLogout_Click,
                mnuNhanVien_Click,    // 1
                mnuLoaiSach_Click,    // 2
                mnuNhaXuatBan_Click,  // 3
                mnuSach_Click,        // 4
                mnuMuonsach_Click,    // 5
                mnuTimSach_Click,     // 6
                mnuTimNhaXB_Click,    // 7
                mnuCheckin_Click,
                mnuPoint_Click,
                mnuDashboard_Click, // ⭐ 8
                       // 9
            };

            int btnHeight = 45;

            for (int i = 0; i < buttons.Length; i++)
            {
                var btn = buttons[i];
                btn.Text = titles[i];
                btn.Dock = DockStyle.Top;
                btn.Height = btnHeight;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(66, 80, 99);
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(10, 0, 0, 0);
                btn.Margin = new Padding(0, 2, 0, 2);
                btn.Click += handlers[i];

                // Gắn vào Sidebar (theo thứ tự đúng)
                pnlSidebar.Controls.Add(btn);
            }

            // ========== PANEL CONTENT ==========
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.WhiteSmoke;

            // ========== STATUS BAR ==========
            statusStrip1.Dock = DockStyle.Bottom;
            statusStrip1.Items.Add(lblStatus);
            statusStrip1.BackColor = Color.FromArgb(240, 240, 240);

            lblStatus.Text = "Đăng nhập: (Chưa đăng nhập)";

            // ========== MAIN FORM ==========
            ClientSize = new Size(1280, 800);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(statusStrip1);
            Name = "MainForm";
            Text = "Hệ thống Quản lý Thư viện";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
