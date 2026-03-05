using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class F_Book
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtId = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtDesc = new TextBox();
            cbCategory = new ComboBox();
            cbPublisher = new ComboBox();
            picBook = new PictureBox();
            gv = new DataGridView();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            pnlForm = new Panel();
            pnlImage = new Panel();
            pnlButtons = new Panel();
            pnlTable = new Panel();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gv).BeginInit();
            pnlForm.SuspendLayout();
            pnlImage.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlTable.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(25, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(330, 30);
            txtId.TabIndex = 0;
            txtId.Enter += TextBox_Enter;
            txtId.Leave += TextBox_Leave;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(25, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 30);
            txtName.TabIndex = 2;
            txtName.Enter += TextBox_Enter;
            txtName.Leave += TextBox_Leave;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(25, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(330, 30);
            txtPrice.TabIndex = 4;
            txtPrice.Enter += TextBox_Enter;
            txtPrice.Leave += TextBox_Leave;
            // 
            // txtDesc
            // 
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Segoe UI", 10F);
            txtDesc.Location = new Point(25, 245);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(330, 80);
            txtDesc.TabIndex = 6;
            txtDesc.Enter += TextBox_Enter;
            txtDesc.Leave += TextBox_Leave;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 10F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(25, 360);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(330, 31);
            cbCategory.TabIndex = 8;
            // 
            // cbPublisher
            // 
            cbPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPublisher.Font = new Font("Segoe UI", 10F);
            cbPublisher.FormattingEnabled = true;
            cbPublisher.Location = new Point(25, 425);
            cbPublisher.Name = "cbPublisher";
            cbPublisher.Size = new Size(330, 31);
            cbPublisher.TabIndex = 10;
            // 
            // picBook
            // 
            picBook.BackColor = Color.FromArgb(248, 250, 252);
            picBook.BorderStyle = BorderStyle.FixedSingle;
            picBook.Cursor = Cursors.Hand;
            picBook.Location = new Point(20, 50);
            picBook.Name = "picBook";
            picBook.Size = new Size(520, 270);
            picBook.SizeMode = PictureBoxSizeMode.Zoom;
            picBook.TabIndex = 1;
            picBook.TabStop = false;
            picBook.Click += picBook_Click;
            // 
            // gv
            // 
            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;
            gv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv.BackgroundColor = Color.White;
            gv.BorderStyle = BorderStyle.None;
            gv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.Padding = new Padding(10, 8, 10, 8);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gv.ColumnHeadersHeight = 45;
            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gv.DefaultCellStyle = dataGridViewCellStyle2;
            gv.EnableHeadersVisualStyles = false;
            gv.GridColor = Color.FromArgb(226, 232, 240);
            gv.Location = new Point(20, 20);
            gv.MultiSelect = false;
            gv.Name = "gv";
            gv.ReadOnly = true;
            gv.RowHeadersVisible = false;
            gv.RowHeadersWidth = 51;
            gv.RowTemplate.Height = 40;
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv.Size = new Size(920, 268);
            gv.TabIndex = 0;
            gv.DoubleClick += gv_DoubleClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(34, 197, 94);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(327, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "➕ Create";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += BtnSave_MouseEnter;
            btnSave.MouseLeave += BtnSave_MouseLeave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(251, 191, 36);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(219, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 38);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "✏️ Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseEnter += BtnUpdate_MouseEnter;
            btnUpdate.MouseLeave += BtnUpdate_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(111, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "🗑️ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += BtnDelete_MouseEnter;
            btnDelete.MouseLeave += BtnDelete_MouseLeave;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(148, 163, 184);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(0, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 38);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "✖ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += BtnCancel_MouseEnter;
            btnCancel.MouseLeave += BtnCancel_MouseLeave;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(59, 130, 246);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(434, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(123, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "🔄 Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            btnRefresh.MouseEnter += BtnRefresh_MouseEnter;
            btnRefresh.MouseLeave += BtnRefresh_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(51, 65, 85);
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(51, 65, 85);
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 3;
            label2.Text = "Tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(51, 65, 85);
            label3.Location = new Point(25, 150);
            label3.Name = "label3";
            label3.Size = new Size(36, 23);
            label3.TabIndex = 5;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(51, 65, 85);
            label4.Location = new Point(25, 215);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 7;
            label4.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(51, 65, 85);
            label5.Location = new Point(25, 330);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 9;
            label5.Text = "Loại sách";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(51, 65, 85);
            label6.Location = new Point(25, 395);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 11;
            label6.Text = "Nhà xuất bản";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(51, 65, 85);
            label7.Location = new Point(20, 20);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 0;
            label7.Text = "Ảnh bìa";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(239, 68, 68);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(405, 330);
            button1.Name = "button1";
            button1.Size = new Size(135, 35);
            button1.TabIndex = 2;
            button1.Text = "🗑️ Xóa ảnh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDeleteImg_Click;
            button1.MouseEnter += BtnDeleteImg_MouseEnter;
            button1.MouseLeave += BtnDeleteImg_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(30, 41, 59);
            label8.Location = new Point(30, 25);
            label8.Name = "label8";
            label8.Size = new Size(278, 46);
            label8.TabIndex = 0;
            label8.Text = "📚 Quản lý sách";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(cbPublisher);
            pnlForm.Controls.Add(label6);
            pnlForm.Controls.Add(cbCategory);
            pnlForm.Controls.Add(label5);
            pnlForm.Controls.Add(txtDesc);
            pnlForm.Controls.Add(label4);
            pnlForm.Controls.Add(txtPrice);
            pnlForm.Controls.Add(label3);
            pnlForm.Controls.Add(txtName);
            pnlForm.Controls.Add(label2);
            pnlForm.Controls.Add(txtId);
            pnlForm.Controls.Add(label1);
            pnlForm.Location = new Point(30, 90);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(20);
            pnlForm.Size = new Size(380, 486);
            pnlForm.TabIndex = 1;
            pnlForm.Paint += Panel_Paint;
            // 
            // pnlImage
            // 
            pnlImage.BackColor = Color.White;
            pnlImage.Controls.Add(button1);
            pnlImage.Controls.Add(picBook);
            pnlImage.Controls.Add(label7);
            pnlImage.Location = new Point(430, 90);
            pnlImage.Name = "pnlImage";
            pnlImage.Padding = new Padding(20);
            pnlImage.Size = new Size(560, 380);
            pnlImage.TabIndex = 2;
            pnlImage.Paint += Panel_Paint;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.White;
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Controls.Add(btnRefresh);
            pnlButtons.Location = new Point(430, 490);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(20);
            pnlButtons.Size = new Size(560, 50);
            pnlButtons.TabIndex = 3;
            pnlButtons.Paint += Panel_Paint;
            // 
            // pnlTable
            // 
            pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTable.BackColor = Color.White;
            pnlTable.Controls.Add(gv);
            pnlTable.Location = new Point(30, 582);
            pnlTable.Name = "pnlTable";
            pnlTable.Padding = new Padding(20);
            pnlTable.Size = new Size(960, 308);
            pnlTable.TabIndex = 4;
            pnlTable.Paint += Panel_Paint;
            // 
            // F_Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1020, 910);
            Controls.Add(pnlTable);
            Controls.Add(pnlButtons);
            Controls.Add(pnlImage);
            Controls.Add(pnlForm);
            Controls.Add(label8);
            Name = "F_Book";
            Padding = new Padding(0, 0, 30, 20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Sách";
            Load += F_Book_Load;
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)gv).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Button button1;
        private Label label8;
        private Panel pnlForm;
        private Panel pnlImage;
        private Panel pnlButtons;
        private Panel pnlTable;

        // Bo tròn góc cho panels
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                int radius = 12;
                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);
            }
        }

        // Hiệu ứng TextBox
        private void TextBox_Enter(object sender, System.EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.FromArgb(240, 249, 255);
            }
        }

        private void TextBox_Leave(object sender, System.EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.White;
            }
        }

        // Hover effects cho buttons
        private void BtnCancel_MouseEnter(object sender, System.EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(100, 116, 139);
        }

        private void BtnCancel_MouseLeave(object sender, System.EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(148, 163, 184);
        }

        private void BtnDelete_MouseEnter(object sender, System.EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
        }

        private void BtnDelete_MouseLeave(object sender, System.EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
        }

        private void BtnUpdate_MouseEnter(object sender, System.EventArgs e)
        {
            btnUpdate.BackColor = Color.FromArgb(245, 158, 11);
        }

        private void BtnUpdate_MouseLeave(object sender, System.EventArgs e)
        {
            btnUpdate.BackColor = Color.FromArgb(251, 191, 36);
        }

        private void BtnSave_MouseEnter(object sender, System.EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(22, 163, 74);
        }

        private void BtnSave_MouseLeave(object sender, System.EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(34, 197, 94);
        }

        private void BtnRefresh_MouseEnter(object sender, System.EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(37, 99, 235);
        }

        private void BtnRefresh_MouseLeave(object sender, System.EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(59, 130, 246);
        }

        private void BtnDeleteImg_MouseEnter(object sender, System.EventArgs e)
        {
            button1.BackColor = Color.FromArgb(220, 38, 38);
        }

        private void BtnDeleteImg_MouseLeave(object sender, System.EventArgs e)
        {
            button1.BackColor = Color.FromArgb(239, 68, 68);
        }
    }
}