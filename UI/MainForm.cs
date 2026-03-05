using System;
using System.Windows.Forms;
using Data.Entities;

namespace UI
{
    public partial class MainForm : Form
    {
        // ✅ Lưu thông tin người dùng đăng nhập
        public User P1 { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Cập nhật trạng thái đăng nhập
            if (P1 != null)
            {
                lblStatus.Text = $"Đăng nhập: {P1.FullName} ({(P1.Role == "Admin" ? "Admin" : "Reader")})";

                // Phân quyền
                if (P1.Role == "Reader")
                {
                    // Ẩn các nút quản lý nếu không phải admin
                    btnNhanVien.Visible = false;
                    btnLoaiSach.Visible = false;
                    btnNhaXuatBan.Visible = false;
                    btnSach.Visible = false; 
                }
            }

            // Mặc định hiển thị dashboard
            ShowForm(new F_Dashboard());
        }

        // Hàm hiển thị form con trong panel content
        private void ShowForm(Form childForm)
        {
            pnlContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            childForm.Show();
        }

        // ========== XỬ LÝ NÚT MENU ==========

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void mnuChangePass_Click(object sender, EventArgs e)
        {
            ShowForm(new ChangePasswordForm(P1.UserId));
        }
        private void mnuDashboard_Click(object sender, EventArgs e)
        {
            ShowForm(new F_Dashboard());
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            ShowForm(new F_User());
        }

        private void mnuLoaiSach_Click(object sender, EventArgs e)
        {
            ShowForm(new F_Category());
        }

        private void mnuNhaXuatBan_Click(object sender, EventArgs e)
        {
            ShowForm(new F_Publisher());
        }
        private void mnuPoint_Click(object sender, EventArgs e)
        {
            ShowForm(new F_ViewPointsHistory());
        }

        private void mnuSach_Click(object sender, EventArgs e)
        {
            ShowForm(new F_Book());
        }

        private void mnuMuonsach_Click(object sender, EventArgs e)
        {
            ShowForm(new F_Borrowbooks());
        }
        private void mnuCheckin_Click(object sender, EventArgs e)
        {
            ShowForm(new F_CheckIn());
        }

        private void mnuTimSach_Click(object sender, EventArgs e)
        {
            ShowForm(new F_TimKiemSach());
        }

        private void mnuTimNhaXB_Click(object sender, EventArgs e)
        {
            ShowForm(new F_TimKiemLoaiNXB());
        }
        private void mnuLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Thực hiện đăng xuất (ví dụ: quay về màn hình đăng nhập hoặc reset trạng thái đăng nhập)
                // Ví dụ:
                lblStatus.Text = "Đăng nhập: (Chưa đăng nhập)";
                //Quay về form đăng nhập(hoặc làm hành động phù hợp với ứng dụng của bạn)
                 new F_Login().Show();
                this.Hide(); // Ẩn MainForm và có thể hiển thị lại form đăng nhập
            }
        }
        public void Logout()
        {
            var result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Thực hiện đăng xuất (ví dụ: quay về màn hình đăng nhập hoặc reset trạng thái đăng nhập)
                lblStatus.Text = "Đăng nhập: (Chưa đăng nhập)";

                // Quay về form đăng nhập
                new F_Login().Show();
                this.Hide(); // Ẩn MainForm và có thể hiển thị lại form đăng nhập
            }
        }

    }
}
