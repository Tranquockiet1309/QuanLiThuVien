namespace UI
{
    partial class F_TimKiemLoaiNXB
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblType;
        private ComboBox cbType;
        private Label lblKeyword;
        private TextBox txtKeyword;

        private Button btnTim;
        private Button btnXemJson;
        private Button btnXuatJson;

        private DataGridView dgvKetQua;
        private RichTextBox rt_json;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblType = new Label();
            cbType = new ComboBox();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            btnTim = new Button();
            btnXemJson = new Button();
            btnXuatJson = new Button();
            dgvKetQua = new DataGridView();
            rt_json = new RichTextBox();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(550, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔍 Tìm kiếm theo Loại sách hoặc Nhà xuất bản";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(20, 72);
            lblType.Name = "lblType";
            lblType.Size = new Size(71, 20);
            lblType.TabIndex = 1;
            lblType.Text = "Tìm theo:";
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.Location = new Point(90, 68);
            cbType.Name = "cbType";
            cbType.Size = new Size(200, 28);
            cbType.TabIndex = 2;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(310, 72);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(65, 20);
            lblKeyword.TabIndex = 3;
            lblKeyword.Text = "Từ khóa:";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(375, 68);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(250, 27);
            txtKeyword.TabIndex = 4;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(640, 67);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm";
            btnTim.Click += btnTim_Click;
            // 
            // btnXemJson
            // 
            btnXemJson.Location = new Point(740, 67);
            btnXemJson.Name = "btnXemJson";
            btnXemJson.Size = new Size(110, 30);
            btnXemJson.TabIndex = 6;
            btnXemJson.Text = "Xem JSON";
            btnXemJson.Click += btnXemJson_Click;
            // 
            // btnXuatJson
            // 
            btnXuatJson.Location = new Point(860, 67);
            btnXuatJson.Name = "btnXuatJson";
            btnXuatJson.Size = new Size(110, 30);
            btnXuatJson.TabIndex = 7;
            btnXuatJson.Text = "Xuất JSON";
            btnXuatJson.Click += btnXuatJson_Click;
            // 
            // dgvKetQua
            // 
            dgvKetQua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKetQua.ColumnHeadersHeight = 29;
            dgvKetQua.Location = new Point(20, 120);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersWidth = 51;
            dgvKetQua.Size = new Size(950, 280);
            dgvKetQua.TabIndex = 8;
            // 
            // rt_json
            // 
            rt_json.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rt_json.Location = new Point(20, 438);
            rt_json.Name = "rt_json";
            rt_json.Size = new Size(950, 140);
            rt_json.TabIndex = 9;
            rt_json.Text = "";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(21, 100);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Tổng có: ";
            // 
            // F_TimKiemLoaiNXB
            // 
            ClientSize = new Size(1000, 580);
            Controls.Add(lblTitle);
            Controls.Add(lblTotal);
            Controls.Add(lblType);
            Controls.Add(cbType);
            Controls.Add(lblKeyword);
            Controls.Add(txtKeyword);
            Controls.Add(btnTim);
            Controls.Add(btnXemJson);
            Controls.Add(btnXuatJson);
            Controls.Add(dgvKetQua);
            Controls.Add(rt_json);
            Name = "F_TimKiemLoaiNXB";
            Text = "Tìm kiếm loại sách & nhà xuất bản";
            Load += F_TimKiemLoaiNXB_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTotal;
    }
}
