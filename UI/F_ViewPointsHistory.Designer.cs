using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class F_ViewPointsHistory
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPointsHistory;
        private System.Windows.Forms.Button btnExportJson;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label lblTitle;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlSearch = new Panel();
            btnExportJson = new Button();
            btnSearch = new Button();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            lblFrom = new Label();
            txtUserId = new TextBox();
            lblUserId = new Label();
            pnlTable = new Panel();
            dgvPointsHistory = new DataGridView();
            lblTotal = new Label();
            lblTitle = new Label();
            pnlSearch.SuspendLayout();
            pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPointsHistory).BeginInit();
            SuspendLayout();
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(btnExportJson);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(dtpTo);
            pnlSearch.Controls.Add(lblTo);
            pnlSearch.Controls.Add(dtpFrom);
            pnlSearch.Controls.Add(lblFrom);
            pnlSearch.Controls.Add(txtUserId);
            pnlSearch.Controls.Add(lblUserId);
            pnlSearch.Location = new Point(30, 80);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(25);
            pnlSearch.Size = new Size(740, 180);
            pnlSearch.TabIndex = 0;
            pnlSearch.Paint += Panel_Paint;
            // 
            // btnExportJson
            // 
            btnExportJson.BackColor = Color.FromArgb(16, 185, 129);
            btnExportJson.FlatAppearance.BorderSize = 0;
            btnExportJson.FlatStyle = FlatStyle.Flat;
            btnExportJson.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportJson.ForeColor = Color.White;
            btnExportJson.Location = new Point(615, 120);
            btnExportJson.Name = "btnExportJson";
            btnExportJson.Size = new Size(100, 38);
            btnExportJson.TabIndex = 7;
            btnExportJson.Text = "📄 Xuất";
            btnExportJson.UseVisualStyleBackColor = false;
            btnExportJson.Click += btnExportExcel_Click;
            btnExportJson.MouseEnter += BtnExport_MouseEnter;
            btnExportJson.MouseLeave += BtnExport_MouseLeave;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(59, 130, 246);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(495, 120);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 38);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "🔍 Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnSearch.MouseEnter += BtnSearch_MouseEnter;
            btnSearch.MouseLeave += BtnSearch_MouseLeave;
            // 
            // dtpTo
            // 
            dtpTo.CalendarFont = new Font("Segoe UI", 10F);
            dtpTo.Font = new Font("Segoe UI", 10F);
            dtpTo.Location = new Point(400, 70);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(315, 30);
            dtpTo.TabIndex = 5;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTo.ForeColor = Color.FromArgb(51, 65, 85);
            lblTo.Location = new Point(400, 40);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(86, 23);
            lblTo.TabIndex = 4;
            lblTo.Text = "Đến ngày";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarFont = new Font("Segoe UI", 10F);
            dtpFrom.Font = new Font("Segoe UI", 10F);
            dtpFrom.Location = new Point(25, 70);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(315, 30);
            dtpFrom.TabIndex = 3;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFrom.ForeColor = Color.FromArgb(51, 65, 85);
            lblFrom.Location = new Point(25, 40);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(75, 23);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "Từ ngày";
            // 
            // txtUserId
            // 
            txtUserId.BorderStyle = BorderStyle.FixedSingle;
            txtUserId.Font = new Font("Segoe UI", 11F);
            txtUserId.Location = new Point(185, 120);
            txtUserId.Name = "txtUserId";
            txtUserId.PlaceholderText = "Nhập mã người dùng...";
            txtUserId.Size = new Size(280, 32);
            txtUserId.TabIndex = 1;
            txtUserId.Enter += TextBox_Enter;
            txtUserId.Leave += TextBox_Leave;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserId.ForeColor = Color.FromArgb(51, 65, 85);
            lblUserId.Location = new Point(25, 125);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(135, 23);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "Mã người dùng";
            // 
            // pnlTable
            // 
            pnlTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTable.BackColor = Color.White;
            pnlTable.Controls.Add(dgvPointsHistory);
            pnlTable.Location = new Point(30, 291);
            pnlTable.Name = "pnlTable";
            pnlTable.Padding = new Padding(20);
            pnlTable.Size = new Size(740, 339);
            pnlTable.TabIndex = 1;
            pnlTable.Paint += Panel_Paint;
            // 
            // dgvPointsHistory
            // 
            dgvPointsHistory.AllowUserToAddRows = false;
            dgvPointsHistory.AllowUserToDeleteRows = false;
            dgvPointsHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPointsHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPointsHistory.BackgroundColor = Color.White;
            dgvPointsHistory.BorderStyle = BorderStyle.None;
            dgvPointsHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPointsHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.Padding = new Padding(10, 8, 10, 8);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPointsHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPointsHistory.ColumnHeadersHeight = 45;
            dgvPointsHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle4.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPointsHistory.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPointsHistory.EnableHeadersVisualStyles = false;
            dgvPointsHistory.GridColor = Color.FromArgb(226, 232, 240);
            dgvPointsHistory.Location = new Point(20, 50);
            dgvPointsHistory.Name = "dgvPointsHistory";
            dgvPointsHistory.ReadOnly = true;
            dgvPointsHistory.RowHeadersVisible = false;
            dgvPointsHistory.RowHeadersWidth = 51;
            dgvPointsHistory.RowTemplate.Height = 40;
            dgvPointsHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPointsHistory.Size = new Size(700, 269);
            dgvPointsHistory.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(51, 65, 85);
            lblTotal.Location = new Point(30, 263);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(179, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "📊 Tổng kết quả: 0";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(383, 41);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "📈 Lịch sử điểm rèn luyện";
            // 
            // F_ViewPointsHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(800, 650);
            Controls.Add(lblTotal);
            Controls.Add(lblTitle);
            Controls.Add(pnlTable);
            Controls.Add(pnlSearch);
            Name = "F_ViewPointsHistory";
            Padding = new Padding(0, 0, 30, 20);
            Text = "Lịch sử điểm rèn luyện";
            Load += F_ViewPointsHistory_Load;
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPointsHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Thêm hiệu ứng bo tròn góc cho panels
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

        // Hiệu ứng hover cho nút Tìm kiếm
        private void BtnSearch_MouseEnter(object sender, System.EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
        }

        private void BtnSearch_MouseLeave(object sender, System.EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(59, 130, 246);
        }

        // Hiệu ứng hover cho nút Xuất
        private void BtnExport_MouseEnter(object sender, System.EventArgs e)
        {
            btnExportJson.BackColor = Color.FromArgb(5, 150, 105);
        }

        private void BtnExport_MouseLeave(object sender, System.EventArgs e)
        {
            btnExportJson.BackColor = Color.FromArgb(16, 185, 129);
        }

        // Hiệu ứng focus cho TextBox
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
    }
}