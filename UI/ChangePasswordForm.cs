using Data;
using Services;

namespace UI
{
    public partial class ChangePasswordForm : Form
    {
        private readonly UserService userService;
        private int currentUserId; // ID của người dùng hiện tại

        public ChangePasswordForm(int userId)
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            userService = new UserService(new LibraryContext());
            currentUserId = userId;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Kiểm tra mật khẩu mới và xác nhận mật khẩu có khớp không
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi phương thức đổi mật khẩu từ UserService
            var result = userService.ChangePassword(currentUserId, oldPassword, newPassword);
            MessageBox.Show(result.Message, "Thông báo", result.Success ? MessageBoxButtons.OK : MessageBoxButtons.OK,
                            result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (result.Success)
            {
                // Nếu đổi mật khẩu thành công, thông báo và chuyển về trang đăng nhập (F_Login)
                var confirmResult = MessageBox.Show("Đổi mật khẩu thành công. Bạn có muốn đăng nhập lại không?",
                                                    "Thông báo",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);

                if (confirmResult == DialogResult.Yes)
                {
                    // Đóng form hiện tại
                    this.Hide();  // Ẩn form đổi mật khẩu

                    // Tìm form MainForm đang mở và gọi Logout
                    var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        mainForm.Logout(); // Gọi phương thức đăng xuất từ MainForm
                    }

                    this.Close();  // Đóng form ChangePasswordForm
                }
            }
        }

    }
}
