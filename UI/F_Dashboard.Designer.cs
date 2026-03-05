using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class F_Dashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Label lblEmpCount;
        private System.Windows.Forms.DataGridView dgvLatestBooks;
        private System.Windows.Forms.Label lblLatest;
        private System.Windows.Forms.Panel pnlBookCard;
        private System.Windows.Forms.Panel pnlEmpCard;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblEmpTitle;
        private System.Windows.Forms.Label lblBookIcon;
        private System.Windows.Forms.Label lblEmpIcon;
        private System.Windows.Forms.Panel pnlTableContainer;
        private System.Windows.Forms.Label lblTableTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlBookCard = new Panel();
            lblBookIcon = new Label();
            lblBookCount = new Label();
            lblBookTitle = new Label();
            pnlEmpCard = new Panel();
            lblEmpIcon = new Label();
            lblEmpCount = new Label();
            lblEmpTitle = new Label();
            pnlTableContainer = new Panel();
            dgvLatestBooks = new DataGridView();
            lblTableTitle = new Label();
            lblLatest = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblPointCount = new Label();
            label3 = new Label();
            pnlBookCard.SuspendLayout();
            pnlEmpCard.SuspendLayout();
            pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLatestBooks).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBookCard
            // 
            pnlBookCard.BackColor = Color.FromArgb(59, 130, 246);
            pnlBookCard.Controls.Add(lblBookIcon);
            pnlBookCard.Controls.Add(lblBookCount);
            pnlBookCard.Controls.Add(lblBookTitle);
            pnlBookCard.Location = new Point(40, 30);
            pnlBookCard.Name = "pnlBookCard";
            pnlBookCard.Size = new Size(280, 140);
            pnlBookCard.TabIndex = 0;
            pnlBookCard.Paint += Card_Paint;
            // 
            // lblBookIcon
            // 
            lblBookIcon.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblBookIcon.ForeColor = Color.White;
            lblBookIcon.Location = new Point(20, 20);
            lblBookIcon.Name = "lblBookIcon";
            lblBookIcon.Size = new Size(80, 60);
            lblBookIcon.TabIndex = 0;
            lblBookIcon.Text = "📚";
            lblBookIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBookCount
            // 
            lblBookCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblBookCount.ForeColor = Color.White;
            lblBookCount.Location = new Point(100, 30);
            lblBookCount.Name = "lblBookCount";
            lblBookCount.Size = new Size(160, 50);
            lblBookCount.TabIndex = 1;
            lblBookCount.Text = "0";
            lblBookCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBookTitle
            // 
            lblBookTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBookTitle.ForeColor = Color.FromArgb(219, 234, 254);
            lblBookTitle.Location = new Point(20, 95);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(240, 30);
            lblBookTitle.TabIndex = 2;
            lblBookTitle.Text = "Tổng số sách";
            lblBookTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlEmpCard
            // 
            pnlEmpCard.BackColor = Color.FromArgb(16, 185, 129);
            pnlEmpCard.Controls.Add(lblEmpIcon);
            pnlEmpCard.Controls.Add(lblEmpCount);
            pnlEmpCard.Controls.Add(lblEmpTitle);
            pnlEmpCard.Location = new Point(340, 30);
            pnlEmpCard.Name = "pnlEmpCard";
            pnlEmpCard.Size = new Size(280, 140);
            pnlEmpCard.TabIndex = 1;
            pnlEmpCard.Paint += Card_Paint;
            // 
            // lblEmpIcon
            // 
            lblEmpIcon.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblEmpIcon.ForeColor = Color.White;
            lblEmpIcon.Location = new Point(20, 20);
            lblEmpIcon.Name = "lblEmpIcon";
            lblEmpIcon.Size = new Size(80, 60);
            lblEmpIcon.TabIndex = 0;
            lblEmpIcon.Text = "👥";
            lblEmpIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpCount
            // 
            lblEmpCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblEmpCount.ForeColor = Color.White;
            lblEmpCount.Location = new Point(100, 30);
            lblEmpCount.Name = "lblEmpCount";
            lblEmpCount.Size = new Size(160, 50);
            lblEmpCount.TabIndex = 1;
            lblEmpCount.Text = "0";
            lblEmpCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmpTitle
            // 
            lblEmpTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEmpTitle.ForeColor = Color.FromArgb(209, 250, 229);
            lblEmpTitle.Location = new Point(20, 95);
            lblEmpTitle.Name = "lblEmpTitle";
            lblEmpTitle.Size = new Size(240, 30);
            lblEmpTitle.TabIndex = 2;
            lblEmpTitle.Text = "Tổng nhân viên";
            lblEmpTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTableContainer
            // 
            pnlTableContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTableContainer.BackColor = Color.White;
            pnlTableContainer.Controls.Add(dgvLatestBooks);
            pnlTableContainer.Controls.Add(lblTableTitle);
            pnlTableContainer.Location = new Point(40, 200);
            pnlTableContainer.Name = "pnlTableContainer";
            pnlTableContainer.Padding = new Padding(20);
            pnlTableContainer.Size = new Size(898, 400);
            pnlTableContainer.TabIndex = 2;
            pnlTableContainer.Paint += Card_Paint;
            // 
            // dgvLatestBooks
            // 
            dgvLatestBooks.AllowUserToAddRows = false;
            dgvLatestBooks.AllowUserToDeleteRows = false;
            dgvLatestBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLatestBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLatestBooks.BackgroundColor = Color.White;
            dgvLatestBooks.BorderStyle = BorderStyle.None;
            dgvLatestBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLatestBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.Padding = new Padding(10, 8, 10, 8);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLatestBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLatestBooks.ColumnHeadersHeight = 45;
            dgvLatestBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLatestBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLatestBooks.EnableHeadersVisualStyles = false;
            dgvLatestBooks.GridColor = Color.FromArgb(226, 232, 240);
            dgvLatestBooks.Location = new Point(20, 70);
            dgvLatestBooks.Name = "dgvLatestBooks";
            dgvLatestBooks.ReadOnly = true;
            dgvLatestBooks.RowHeadersVisible = false;
            dgvLatestBooks.RowHeadersWidth = 51;
            dgvLatestBooks.RowTemplate.Height = 40;
            dgvLatestBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLatestBooks.Size = new Size(858, 310);
            dgvLatestBooks.TabIndex = 1;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTableTitle.Location = new Point(20, 20);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(321, 32);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "📖 Sách mới thêm gần đây";
            // 
            // lblLatest
            // 
            lblLatest.AutoSize = true;
            lblLatest.Location = new Point(0, 0);
            lblLatest.Name = "lblLatest";
            lblLatest.Size = new Size(0, 20);
            lblLatest.TabIndex = 3;
            lblLatest.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblPointCount);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(638, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 140);
            panel1.TabIndex = 1;
            panel1.Paint += Card_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 60);
            label1.TabIndex = 0;
            label1.Text = "👥";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPointCount
            // 
            lblPointCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblPointCount.ForeColor = Color.White;
            lblPointCount.Location = new Point(100, 30);
            lblPointCount.Name = "lblPointCount";
            lblPointCount.Size = new Size(160, 50);
            lblPointCount.TabIndex = 1;
            lblPointCount.Text = "0";
            lblPointCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(209, 250, 229);
            label3.Location = new Point(20, 95);
            label3.Name = "label3";
            label3.Size = new Size(240, 30);
            label3.TabIndex = 2;
            label3.Text = "Tổng user checkin";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // F_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(978, 630);
            Controls.Add(lblLatest);
            Controls.Add(pnlTableContainer);
            Controls.Add(panel1);
            Controls.Add(pnlEmpCard);
            Controls.Add(pnlBookCard);
            Name = "F_Dashboard";
            Padding = new Padding(0, 0, 40, 30);
            Text = "📊 Dashboard - Tổng quan hệ thống";
            Load += F_Dashboard_Load;
            pnlBookCard.ResumeLayout(false);
            pnlEmpCard.ResumeLayout(false);
            pnlTableContainer.ResumeLayout(false);
            pnlTableContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLatestBooks).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        // Thêm hiệu ứng shadow cho cards
        private void Card_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Bo tròn góc
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

        private Panel panel1;
        private Label label1;
        private Label lblPointCount;
        private Label label3;
    }
}