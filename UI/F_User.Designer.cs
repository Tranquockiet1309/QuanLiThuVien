using System.Windows.Forms;

namespace UI
{
    partial class F_User
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
            panel1 = new Panel();
            rt_json = new RichTextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            cb_permit = new ComboBox();
            ck_active = new CheckBox();
            dt_Birthday = new DateTimePicker();
            txt_address = new TextBox();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            txt_username = new TextBox();
            txt_fullname = new TextBox();
            txtId = new TextBox();
            labelAddress = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            gv = new DataGridView();
            btnRefresh = new Button();
            btnExport = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(rt_json);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cb_permit);
            panel1.Controls.Add(ck_active);
            panel1.Controls.Add(dt_Birthday);
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_pass);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(txt_fullname);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(labelAddress);
            panel1.Controls.Add(labelPhone);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 678);
            panel1.TabIndex = 0;
            // 
            // rt_json
            // 
            rt_json.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rt_json.Location = new Point(9, 563);
            rt_json.Name = "rt_json";
            rt_json.Size = new Size(366, 112);
            rt_json.TabIndex = 12;
            rt_json.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Location = new Point(303, 520);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(72, 39);
            btnSave.TabIndex = 11;
            btnSave.Text = "Create";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(203, 520);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(72, 39);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(109, 520);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 39);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.Location = new Point(9, 520);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(72, 39);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cb_permit
            // 
            cb_permit.FormattingEnabled = true;
            cb_permit.Location = new Point(87, 485);
            cb_permit.Name = "cb_permit";
            cb_permit.Size = new Size(222, 28);
            cb_permit.TabIndex = 7;
            // 
            // ck_active
            // 
            ck_active.AutoSize = true;
            ck_active.Font = new Font("Segoe UI", 8F);
            ck_active.Location = new Point(13, 456);
            ck_active.Name = "ck_active";
            ck_active.Size = new Size(129, 23);
            ck_active.TabIndex = 6;
            ck_active.Text = "Active tài khoản";
            ck_active.UseVisualStyleBackColor = true;
            // 
            // dt_Birthday
            // 
            dt_Birthday.Format = DateTimePickerFormat.Short;
            dt_Birthday.Location = new Point(13, 158);
            dt_Birthday.Name = "dt_Birthday";
            dt_Birthday.Size = new Size(362, 27);
            dt_Birthday.TabIndex = 3;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(13, 370);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(362, 27);
            txt_address.TabIndex = 5;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(13, 317);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(362, 27);
            txt_phone.TabIndex = 4;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(13, 264);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(362, 27);
            txt_email.TabIndex = 4;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(13, 423);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(362, 27);
            txt_pass.TabIndex = 6;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(13, 211);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(362, 27);
            txt_username.TabIndex = 4;
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(12, 109);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(363, 27);
            txt_fullname.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(363, 27);
            txtId.TabIndex = 1;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 9F);
            labelAddress.Location = new Point(13, 347);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(55, 20);
            labelAddress.TabIndex = 0;
            labelAddress.Text = "Địa chỉ";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 9F);
            labelPhone.Location = new Point(13, 294);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(97, 20);
            labelPhone.TabIndex = 0;
            labelPhone.Text = "Số điện thoại";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F);
            labelEmail.Location = new Point(13, 241);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(13, 489);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 0;
            label7.Text = "Quyền:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(13, 400);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 0;
            label6.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(13, 188);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 0;
            label5.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(13, 135);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin nhân viên";
            // 
            // panel2
            // 
            panel2.Controls.Add(gv);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnExport);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(390, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 678);
            panel2.TabIndex = 1;
            // 
            // gv
            // 
            gv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv.Location = new Point(6, 57);
            gv.Name = "gv";
            gv.RowHeadersWidth = 51;
            gv.Size = new Size(708, 618);
            gv.TabIndex = 6;
            gv.DoubleClick += gv_DoubleClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Silver;
            btnRefresh.Location = new Point(6, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 39);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Tải dữ liệu";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Blue;
            btnExport.Location = new Point(141, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(129, 39);
            btnExport.TabIndex = 14;
            btnExport.Text = "Xuất Json";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // F_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 678);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "F_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_App3";
            Load += F_User_Load;
            Shown += F_User_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DateTimePicker dt_Birthday;
        private TextBox txt_pass;
        private TextBox txt_username;
        private TextBox txt_fullname;
        private TextBox txtId;
        private ComboBox cb_permit;
        private CheckBox ck_active;
        private RichTextBox rt_json;
        private Button btnSave;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnExport;
        private DataGridView gv;

        // NEW controls
        private TextBox txt_email;
        private TextBox txt_phone;
        private TextBox txt_address;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelAddress;
    }
}
