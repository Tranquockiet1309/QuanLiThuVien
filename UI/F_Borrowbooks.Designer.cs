namespace UI
{
    partial class F_Borrowbooks
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Button btnSelectBook;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvBorrowbooks;
        private System.Windows.Forms.Label lblStatus;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            panelTop = new Panel();
            lblUserId = new Label();
            txtUserId = new TextBox();
            lblBookName = new Label();
            lblBookId = new Label();
            txtBookId = new TextBox();
            btnSelectBook = new Button();
            btnBorrow = new Button();
            btnReturn = new Button();
            btnReload = new Button();
            dgvBorrowbooks = new DataGridView();
            lblStatus = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowbooks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10, 8, 10, 8);
            lblTitle.Size = new Size(1008, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚 Quản lý mượn / trả sách";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = Color.FromArgb(245, 247, 250);
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(lblUserId);
            panelTop.Controls.Add(txtUserId);
            panelTop.Controls.Add(lblBookName);
            panelTop.Controls.Add(lblBookId);
            panelTop.Controls.Add(txtBookId);
            panelTop.Controls.Add(btnSelectBook);
            panelTop.Controls.Add(btnBorrow);
            panelTop.Controls.Add(btnReturn);
            panelTop.Controls.Add(btnReload);
            panelTop.Location = new Point(12, 58);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(984, 84);
            panelTop.TabIndex = 1;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(12, 10);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(111, 20);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "Mã người dùng";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(12, 33);
            txtUserId.Name = "txtUserId";
            txtUserId.PlaceholderText = "VD: 1001";
            txtUserId.Size = new Size(160, 27);
            txtUserId.TabIndex = 1;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(291, 40);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(65, 20);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "Tên sách";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(190, 10);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(63, 20);
            lblBookId.TabIndex = 2;
            lblBookId.Text = "Mã sách";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(190, 33);
            txtBookId.Name = "txtBookId";
            txtBookId.PlaceholderText = "VD: 501";
            txtBookId.Size = new Size(85, 27);
            txtBookId.TabIndex = 3;
            // 
            // btnSelectBook
            // 
            btnSelectBook.Location = new Point(505, 33);
            btnSelectBook.Name = "btnSelectBook";
            btnSelectBook.Size = new Size(98, 29);
            btnSelectBook.TabIndex = 4;
            btnSelectBook.Text = "Chọn sách...";
            btnSelectBook.UseVisualStyleBackColor = true;
            btnSelectBook.Click += btnSelectBook_Click;
            // 
            // btnBorrow
            // 
            btnBorrow.Anchor = AnchorStyles.Top;
            btnBorrow.BackColor = Color.FromArgb(56, 142, 60);
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.ForeColor = Color.White;
            btnBorrow.Location = new Point(609, 29);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(120, 35);
            btnBorrow.TabIndex = 5;
            btnBorrow.Text = "Mượn sách";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.Anchor = AnchorStyles.Top;
            btnReturn.BackColor = Color.FromArgb(25, 118, 210);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(735, 29);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(120, 36);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Trả sách";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReload.Location = new Point(861, 33);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(105, 33);
            btnReload.TabIndex = 7;
            btnReload.Text = "Tải lại";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowbooks
            // 
            dgvBorrowbooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBorrowbooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowbooks.Location = new Point(12, 156);
            dgvBorrowbooks.Name = "dgvBorrowbooks";
            dgvBorrowbooks.RowHeadersVisible = false;
            dgvBorrowbooks.RowHeadersWidth = 51;
            dgvBorrowbooks.RowTemplate.Height = 28;
            dgvBorrowbooks.Size = new Size(984, 444);
            dgvBorrowbooks.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location = new Point(12, 608);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(984, 24);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Sẵn sàng";
            // 
            // F_Borrowbooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 641);
            Controls.Add(lblStatus);
            Controls.Add(dgvBorrowbooks);
            Controls.Add(panelTop);
            Controls.Add(lblTitle);
            Name = "F_Borrowbooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý mượn / trả sách";
            Load += F_Borrowbooks_Load;
            Shown += F_Borrowbooks_Shown;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowbooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBookName;
    }
}
