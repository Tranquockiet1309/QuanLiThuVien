using System;
using System.Linq;
using System.Windows.Forms;
using Data;                 // LibraryContext
using Data.Entities;        // User
using Services;             // UserService

namespace UI
{
    public partial class F_Login : Form
    {
        // Dùng 1 DbContext cho form Login
        private readonly LibraryContext db;
        private readonly UserService userService;

        public F_Login()
        {
            InitializeComponent();

            // Khởi tạo DbContext + Service
            db = new LibraryContext();
            userService = new UserService(db);
        }

        private void F_Login_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null; // bỏ focus ban đầu nếu muốn
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            // Có thể bind “ghi nhớ đăng nhập” tại đây
            txtUser.Text = Properties.Settings.Default.RememberUser;
            txtPass.Text = Properties.Settings.Default.RememberPass;
            chkRemember.Checked = !string.IsNullOrEmpty(txtUser.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy user theo username (so sánh không phân biệt hoa/thường)
            var user = db.Users
                         .FirstOrDefault(u => u.UserName.ToLower() == username.ToLower());

            if (user == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                    "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // So khớp mật khẩu — hiện đang plaintext theo mô hình của bạn
            // TODO: nếu lưu HASH, thay so sánh này bằng VerifyHash(password, user.Password)
            if (!string.Equals(user.Password, password, StringComparison.Ordinal))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                    "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!user.IsActive)
            {
                MessageBox.Show("Tài khoản chưa được kích hoạt, vui lòng liên hệ Admin!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

             //(Tuỳ chọn) Ghi nhớ đăng nhập
             if (chkRemember.Checked)
            {
                Properties.Settings.Default.RememberUser = username;
                Properties.Settings.Default.RememberPass = password; // KHÔNG KHUYẾN NGHỊ lưu plaintext
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.RememberUser = "";
                Properties.Settings.Default.RememberPass = "";
                Properties.Settings.Default.Save();
            }

            // Mở MainForm – truyền user đăng nhập và (khuyến nghị) dùng chung db
            var mainForm = new MainForm();
            mainForm.P1 = user; // MainForm sẽ đọc Role/FullName từ đây
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- Nếu muốn dùng HASH (khuyến nghị), thêm các hàm dưới và thay so sánh mật khẩu ở trên ---
        // private bool VerifyHash(string inputPassword, string storedHash)
        // {
        //     // ví dụ BCrypt:
        //     return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);
        // }

    }
}
