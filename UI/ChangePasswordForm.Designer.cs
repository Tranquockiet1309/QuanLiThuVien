namespace UI
{
    partial class ChangePasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnChangePassword = new Button();
            lblOldPassword = new Label();
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();
            pnlLeft = new Panel();
            picLogo = new PictureBox();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            pnlRight = new Panel();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(190, 50);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(200, 27);
            txtOldPassword.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(190, 100);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(200, 27);
            txtNewPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(190, 150);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(200, 27);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(59, 130, 246);
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(138, 199);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(200, 48);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Đổi Mật Khẩu";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Location = new Point(50, 50);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(89, 20);
            lblOldPassword.TabIndex = 4;
            lblOldPassword.Text = "Mật khẩu cũ";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(50, 100);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(100, 20);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(50, 150);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(134, 20);
            lblConfirmPassword.TabIndex = 6;
            lblConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(37, 99, 235);
            pnlLeft.Controls.Add(picLogo);
            pnlLeft.Controls.Add(lblSubtitle);
            pnlLeft.Controls.Add(lblWelcome);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(450, 509);
            pnlLeft.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = Properties.Resources.z5967889062212_0f3027913beec790214ebd20f61d9e42;
            picLogo.Location = new Point(124, 47);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 200);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(191, 219, 254);
            lblSubtitle.Location = new Point(40, 380);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(370, 60);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Quản lý tài khoản người dùng dễ dàng và nhanh chóng.";
            lblSubtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(40, 250);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(370, 120);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Đổi Mật Khẩu";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(248, 250, 252);
            pnlRight.Controls.Add(lblConfirmPassword);
            pnlRight.Controls.Add(lblNewPassword);
            pnlRight.Controls.Add(lblOldPassword);
            pnlRight.Controls.Add(btnChangePassword);
            pnlRight.Controls.Add(txtConfirmPassword);
            pnlRight.Controls.Add(txtNewPassword);
            pnlRight.Controls.Add(txtOldPassword);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(450, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(500, 509);
            pnlRight.TabIndex = 0;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 509);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnChangePassword;
        private Label lblOldPassword;
        private Label lblNewPassword;
        private Label lblConfirmPassword;
        private Panel pnlLeft;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Panel pnlRight;
        private PictureBox picLogo;

        
       
    }
}
