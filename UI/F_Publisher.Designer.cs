using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI
{
    partial class F_Publisher
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
            picLogo = new PictureBox();
            btnDeleteImg = new Button();
            rt_json = new RichTextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            txtId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvPublisher = new DataGridView();
            btnRefresh = new Button();
            btnExport = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(btnDeleteImg);
            panel1.Controls.Add(rt_json);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 519);
            panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(12, 310);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(167, 90);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 100;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // btnDeleteImg
            // 
            btnDeleteImg.BackColor = Color.LightCoral;
            btnDeleteImg.Location = new Point(195, 371);
            btnDeleteImg.Name = "btnDeleteImg";
            btnDeleteImg.Size = new Size(95, 29);
            btnDeleteImg.TabIndex = 7;
            btnDeleteImg.Text = "Xóa ảnh";
            btnDeleteImg.UseVisualStyleBackColor = false;
            btnDeleteImg.Click += btnDeleteImg_Click;
            // 
            // rt_json
            // 
            rt_json.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rt_json.Location = new Point(3, 446);
            rt_json.Name = "rt_json";
            rt_json.Size = new Size(281, 52);
            rt_json.TabIndex = 11;
            rt_json.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Location = new Point(226, 406);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(64, 39);
            btnSave.TabIndex = 10;
            btnSave.Text = "Create";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(154, 406);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(70, 39);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(81, 406);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 39);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.Location = new Point(9, 406);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(70, 39);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(9, 257);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(10, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(281, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(10, 159);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(281, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(10, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(281, 27);
            txtName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 237);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // txtId
            // 
            txtId.Location = new Point(10, 58);
            txtId.Name = "txtId";
            txtId.Size = new Size(281, 27);
            txtId.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 188);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 0;
            label6.Text = "Sdt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 287);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 0;
            label5.Text = "Ảnh";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 139);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 87);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên nhà xuất bản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã nhà xuất bản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(30, 4);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin nhà xuất bản";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dgvPublisher);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnExport);
            panel2.Location = new Point(300, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 519);
            panel2.TabIndex = 1;
            // 
            // dgvPublisher
            // 
            dgvPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPublisher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPublisher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublisher.Location = new Point(3, 52);
            dgvPublisher.Name = "dgvPublisher";
            dgvPublisher.RowHeadersWidth = 51;
            dgvPublisher.Size = new Size(490, 464);
            dgvPublisher.TabIndex = 6;
            dgvPublisher.DoubleClick += dgvPublisher_DoubleClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Silver;
            btnRefresh.Location = new Point(3, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 39);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Tải dữ liệu";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Blue;
            btnExport.Location = new Point(138, 10);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(129, 39);
            btnExport.TabIndex = 13;
            btnExport.Text = "Xuất Json";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // F_Publisher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "F_Publisher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_Publisher";
            Load += F_Publisher_Load;
            Shown += F_Publisher_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox picLogo;
        private Button btnDeleteImg;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtId;
        private RichTextBox rt_json;
        private Button btnSave;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnExport;
        private DataGridView dgvPublisher;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
    }
}
