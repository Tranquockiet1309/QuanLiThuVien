using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class F_Login : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            txtUser = new TextBox();
            txtPass = new TextBox();
            chkRemember = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            btnCancel = new Button();
            label4 = new Label();
            pnlLeft = new Panel();
            picLogo = new PictureBox();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            pnlRight = new Panel();
            linkRegister = new LinkLabel();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 11F);
            txtUser.Location = new Point(80, 190);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(340, 32);
            txtUser.TabIndex = 0;
            txtUser.Enter += TextBox_Enter;
            txtUser.Leave += TextBox_Leave;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.Location = new Point(80, 270);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.Size = new Size(340, 32);
            txtPass.TabIndex = 1;
            txtPass.Enter += TextBox_Enter;
            txtPass.Leave += TextBox_Leave;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Segoe UI", 9.5F);
            chkRemember.ForeColor = Color.FromArgb(100, 116, 139);
            chkRemember.Location = new Point(80, 315);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(156, 25);
            chkRemember.TabIndex = 2;
            chkRemember.Text = "Ghi nhớ tài khoản";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(80, 100);
            label1.Name = "label1";
            label1.Size = new Size(211, 50);
            label1.TabIndex = 9;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(51, 65, 85);
            label2.Location = new Point(80, 160);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 8;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(51, 65, 85);
            label3.Location = new Point(80, 240);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(59, 130, 246);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(80, 360);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(340, 48);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(71, 85, 105);
            btnCancel.Location = new Point(80, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(340, 45);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnExit_Click;
            btnCancel.MouseEnter += btnCancel_MouseEnter;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(100, 116, 139);
            label4.Location = new Point(130, 485);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 6;
            label4.Text = "Bạn chưa có tài khoản?";
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
            pnlLeft.Size = new Size(450, 600);
            pnlLeft.TabIndex = 1;
            // 
            // picLogo
            // 
            
            picLogo.BackColor = Color.White;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.SizeMode = PictureBoxSizeMode.Zoom; // Cập nhật SizeMode để giữ tỷ lệ ảnh
            picLogo.Location = new Point(124, 47);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 200); // Bạn có thể điều chỉnh kích thước khung nếu cần
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
            lblSubtitle.Text = "Quản lý sách, độc giả và mượn trả\nmột cách dễ dàng và hiệu quả";
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
            lblWelcome.Text = "Chào mừng đến với\nHệ thống Quản lý\nThư viện";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(248, 250, 252);
            pnlRight.Controls.Add(linkRegister);
            pnlRight.Controls.Add(label4);
            pnlRight.Controls.Add(chkRemember);
            pnlRight.Controls.Add(btnCancel);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Controls.Add(label3);
            pnlRight.Controls.Add(label2);
            pnlRight.Controls.Add(label1);
            pnlRight.Controls.Add(txtPass);
            pnlRight.Controls.Add(txtUser);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(450, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(500, 600);
            pnlRight.TabIndex = 0;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            linkRegister.LinkColor = Color.FromArgb(59, 130, 246);
            linkRegister.Location = new Point(290, 485);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(66, 20);
            linkRegister.TabIndex = 5;
            linkRegister.TabStop = true;
            linkRegister.Text = "Đăng ký";
            // 
            // F_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 600);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "F_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            Load += F_Login_Load;
            Shown += F_Login_Shown;
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkRemember;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button btnCancel;
        private Label label4;
        private Panel pnlLeft;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Panel pnlRight;
        private PictureBox picLogo;
        private LinkLabel linkRegister;

        // Thêm các event handlers cho hiệu ứng hover
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(37, 99, 235);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(59, 130, 246);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(241, 245, 249);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.White;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.FromArgb(240, 249, 255);
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.White;
            }
        }
    }
}