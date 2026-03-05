namespace UI
{
    partial class F_TimKiemSach
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private TextBox txtKeyword;
        private Button btnSearch;
        private Button btnPick;
        private Button btnExportJson;
        private Button btnViewJson;
        private DataGridView dgvKetQua;
        private RichTextBox rt_json;
        private Label lblCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtKeyword = new TextBox();
            btnSearch = new Button();
            btnPick = new Button();
            btnExportJson = new Button();
            btnViewJson = new Button();
            dgvKetQua = new DataGridView();
            colImage = new DataGridViewImageColumn();
            rt_json = new RichTextBox();
            lblCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10);
            lblTitle.Size = new Size(1080, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔍 Tìm kiếm sách";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(12, 65);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Nhập tên, mã sách...";
            txtKeyword.Size = new Size(520, 27);
            txtKeyword.TabIndex = 1;
            txtKeyword.KeyDown += txtKeyword_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(540, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnPick
            // 
            btnPick.Location = new Point(646, 64);
            btnPick.Name = "btnPick";
            btnPick.Size = new Size(100, 29);
            btnPick.TabIndex = 3;
            btnPick.Text = "Chọn";
            btnPick.Visible = false;
            btnPick.Click += btnPick_Click;
            // 
            // btnExportJson
            // 
            btnExportJson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportJson.Location = new Point(874, 64);
            btnExportJson.Name = "btnExportJson";
            btnExportJson.Size = new Size(90, 29);
            btnExportJson.TabIndex = 4;
            btnExportJson.Text = "Xuất JSON";
            btnExportJson.Click += btnExportJson_Click;
            // 
            // btnViewJson
            // 
            btnViewJson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewJson.Location = new Point(970, 64);
            btnViewJson.Name = "btnViewJson";
            btnViewJson.Size = new Size(90, 29);
            btnViewJson.TabIndex = 5;
            btnViewJson.Text = "Xem JSON";
            // 
            // dgvKetQua
            // 
            dgvKetQua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKetQua.ColumnHeadersHeight = 29;
            dgvKetQua.Columns.AddRange(new DataGridViewColumn[] { colImage });
            dgvKetQua.Location = new Point(12, 110);
            dgvKetQua.MultiSelect = false;
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersVisible = false;
            dgvKetQua.RowHeadersWidth = 51;
            dgvKetQua.RowTemplate.Height = 74;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.Size = new Size(1050, 360);
            dgvKetQua.TabIndex = 6;
            // 
            // colImage
            // 
            colImage.HeaderText = "Ảnh";
            colImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colImage.MinimumWidth = 6;
            colImage.Name = "colImage";
            colImage.Width = 90;
            // 
            // rt_json
            // 
            rt_json.Location = new Point(12, 510);
            rt_json.Name = "rt_json";
            rt_json.Size = new Size(1050, 130);
            rt_json.TabIndex = 8;
            rt_json.Text = "";
            // 
            // lblCount
            // 
            lblCount.Location = new Point(12, 480);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(400, 25);
            lblCount.TabIndex = 7;
            lblCount.Text = "Kết quả: 0 sách";
            // 
            // F_TimKiemSach
            // 
            ClientSize = new Size(1080, 660);
            Controls.Add(lblTitle);
            Controls.Add(txtKeyword);
            Controls.Add(btnSearch);
            Controls.Add(btnPick);
            Controls.Add(btnExportJson);
            Controls.Add(btnViewJson);
            Controls.Add(dgvKetQua);
            Controls.Add(lblCount);
            Controls.Add(rt_json);
            Name = "F_TimKiemSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tìm kiếm sách";
            Load += F_TimKiemSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewImageColumn colImage;
    }
}
