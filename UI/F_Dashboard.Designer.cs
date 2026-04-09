using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class F_Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        // Header controls
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.Label lblUserProfile;

        // Cards
        private System.Windows.Forms.Panel pnlBookCard;
        private System.Windows.Forms.Panel pnlBookTopBar;
        private System.Windows.Forms.Label lblBookIcon;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Label lblBookTrend;

        private System.Windows.Forms.Panel pnlEmpCard;
        private System.Windows.Forms.Panel pnlEmpTopBar;
        private System.Windows.Forms.Label lblEmpIcon;
        private System.Windows.Forms.Label lblEmpTitle;
        private System.Windows.Forms.Label lblEmpCount;
        private System.Windows.Forms.Label lblEmpTrend;

        private System.Windows.Forms.Panel pnlPointCard;
        private System.Windows.Forms.Panel pnlPointTopBar;
        private System.Windows.Forms.Label lblPointIcon;
        private System.Windows.Forms.Label lblPointTitle;
        private System.Windows.Forms.Label lblPointCount;
        private System.Windows.Forms.Label lblPointTrend;

        // Table
        private System.Windows.Forms.Panel pnlTableContainer;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.DataGridView dgvLatestBooks;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Label lblPagination;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.lblUserProfile = new System.Windows.Forms.Label();
            
            this.pnlBookCard = new System.Windows.Forms.Panel();
            this.pnlBookTopBar = new System.Windows.Forms.Panel();
            this.lblBookIcon = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.lblBookTrend = new System.Windows.Forms.Label();
            
            this.pnlEmpCard = new System.Windows.Forms.Panel();
            this.pnlEmpTopBar = new System.Windows.Forms.Panel();
            this.lblEmpIcon = new System.Windows.Forms.Label();
            this.lblEmpTitle = new System.Windows.Forms.Label();
            this.lblEmpCount = new System.Windows.Forms.Label();
            this.lblEmpTrend = new System.Windows.Forms.Label();
            
            this.pnlPointCard = new System.Windows.Forms.Panel();
            this.pnlPointTopBar = new System.Windows.Forms.Panel();
            this.lblPointIcon = new System.Windows.Forms.Label();
            this.lblPointTitle = new System.Windows.Forms.Label();
            this.lblPointCount = new System.Windows.Forms.Label();
            this.lblPointTrend = new System.Windows.Forms.Label();
            
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.dgvLatestBooks = new System.Windows.Forms.DataGridView();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.lblPagination = new System.Windows.Forms.Label();
            
            this.pnlSearch.SuspendLayout();
            this.pnlBookCard.SuspendLayout();
            this.pnlEmpCard.SuspendLayout();
            this.pnlPointCard.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            this.pnlPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLatestBooks)).BeginInit();
            this.SuspendLayout();
            
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(30, 20);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(217, 50);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Dashboard";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearchIcon);
            this.pnlSearch.Location = new System.Drawing.Point(620, 28);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(250, 40);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(10, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Global search";
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchIcon.Location = new System.Drawing.Point(220, 5);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(30, 28);
            this.lblSearchIcon.TabIndex = 1;
            this.lblSearchIcon.Text = "🔍";
            // 
            // lblUserProfile
            // 
            this.lblUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserProfile.AutoSize = true;
            this.lblUserProfile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUserProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblUserProfile.Location = new System.Drawing.Point(890, 35);
            this.lblUserProfile.Name = "lblUserProfile";
            this.lblUserProfile.Size = new System.Drawing.Size(186, 25);
            this.lblUserProfile.TabIndex = 2;
            this.lblUserProfile.Text = "👤 Trần Quốc Kiệt ⚙";
            // 
            // pnlBookCard
            // 
            this.pnlBookCard.BackColor = System.Drawing.Color.White;
            this.pnlBookCard.Controls.Add(this.pnlBookTopBar);
            this.pnlBookCard.Controls.Add(this.lblBookIcon);
            this.pnlBookCard.Controls.Add(this.lblBookTitle);
            this.pnlBookCard.Controls.Add(this.lblBookCount);
            this.pnlBookCard.Controls.Add(this.lblBookTrend);
            this.pnlBookCard.Location = new System.Drawing.Point(40, 100);
            this.pnlBookCard.Name = "pnlBookCard";
            this.pnlBookCard.Size = new System.Drawing.Size(320, 160);
            this.pnlBookCard.TabIndex = 3;
            //this.pnlBookCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // pnlBookTopBar
            // 
            this.pnlBookTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.pnlBookTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBookTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBookTopBar.Name = "pnlBookTopBar";
            this.pnlBookTopBar.Size = new System.Drawing.Size(320, 6);
            this.pnlBookTopBar.TabIndex = 0;
            // 
            // lblBookIcon
            // 
            this.lblBookIcon.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.lblBookIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblBookIcon.Location = new System.Drawing.Point(20, 30);
            this.lblBookIcon.Name = "lblBookIcon";
            this.lblBookIcon.Size = new System.Drawing.Size(100, 100);
            this.lblBookIcon.TabIndex = 1;
            this.lblBookIcon.Text = "📚";
            this.lblBookIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBookTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblBookTitle.Location = new System.Drawing.Point(130, 25);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(180, 28);
            this.lblBookTitle.TabIndex = 2;
            this.lblBookTitle.Text = "Tổng số sách";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookCount
            // 
            this.lblBookCount.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblBookCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBookCount.Location = new System.Drawing.Point(130, 55);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(180, 60);
            this.lblBookCount.TabIndex = 3;
            this.lblBookCount.Text = "0";
            this.lblBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookTrend
            // 
            this.lblBookTrend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblBookTrend.Location = new System.Drawing.Point(130, 120);
            this.lblBookTrend.Name = "lblBookTrend";
            this.lblBookTrend.Size = new System.Drawing.Size(180, 20);
            this.lblBookTrend.TabIndex = 4;
            this.lblBookTrend.Text = "📈 +15 trong 7 ngày qua";
            this.lblBookTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlEmpCard
            // 
            this.pnlEmpCard.BackColor = System.Drawing.Color.White;
            this.pnlEmpCard.Controls.Add(this.pnlEmpTopBar);
            this.pnlEmpCard.Controls.Add(this.lblEmpIcon);
            this.pnlEmpCard.Controls.Add(this.lblEmpTitle);
            this.pnlEmpCard.Controls.Add(this.lblEmpCount);
            this.pnlEmpCard.Controls.Add(this.lblEmpTrend);
            this.pnlEmpCard.Location = new System.Drawing.Point(390, 100);
            this.pnlEmpCard.Name = "pnlEmpCard";
            this.pnlEmpCard.Size = new System.Drawing.Size(320, 160);
            this.pnlEmpCard.TabIndex = 4;
            //this.pnlEmpCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // pnlEmpTopBar
            // 
            this.pnlEmpTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.pnlEmpTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmpTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlEmpTopBar.Name = "pnlEmpTopBar";
            this.pnlEmpTopBar.Size = new System.Drawing.Size(320, 6);
            this.pnlEmpTopBar.TabIndex = 0;
            // 
            // lblEmpIcon
            // 
            this.lblEmpIcon.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.lblEmpIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.lblEmpIcon.Location = new System.Drawing.Point(20, 30);
            this.lblEmpIcon.Name = "lblEmpIcon";
            this.lblEmpIcon.Size = new System.Drawing.Size(100, 100);
            this.lblEmpIcon.TabIndex = 1;
            this.lblEmpIcon.Text = "👥";
            this.lblEmpIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpTitle
            // 
            this.lblEmpTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmpTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmpTitle.Location = new System.Drawing.Point(130, 25);
            this.lblEmpTitle.Name = "lblEmpTitle";
            this.lblEmpTitle.Size = new System.Drawing.Size(180, 28);
            this.lblEmpTitle.TabIndex = 2;
            this.lblEmpTitle.Text = "Nhân viên hoạt động";
            this.lblEmpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmpCount
            // 
            this.lblEmpCount.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblEmpCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEmpCount.Location = new System.Drawing.Point(130, 55);
            this.lblEmpCount.Name = "lblEmpCount";
            this.lblEmpCount.Size = new System.Drawing.Size(180, 60);
            this.lblEmpCount.TabIndex = 3;
            this.lblEmpCount.Text = "0";
            this.lblEmpCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmpTrend
            // 
            this.lblEmpTrend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmpTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblEmpTrend.Location = new System.Drawing.Point(130, 120);
            this.lblEmpTrend.Name = "lblEmpTrend";
            this.lblEmpTrend.Size = new System.Drawing.Size(180, 20);
            this.lblEmpTrend.TabIndex = 4;
            this.lblEmpTrend.Text = "📈 +1 nhân viên mới";
            this.lblEmpTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPointCard
            // 
            this.pnlPointCard.BackColor = System.Drawing.Color.White;
            this.pnlPointCard.Controls.Add(this.pnlPointTopBar);
            this.pnlPointCard.Controls.Add(this.lblPointIcon);
            this.pnlPointCard.Controls.Add(this.lblPointTitle);
            this.pnlPointCard.Controls.Add(this.lblPointCount);
            this.pnlPointCard.Controls.Add(this.lblPointTrend);
            this.pnlPointCard.Location = new System.Drawing.Point(740, 100);
            this.pnlPointCard.Name = "pnlPointCard";
            this.pnlPointCard.Size = new System.Drawing.Size(320, 160);
            this.pnlPointCard.TabIndex = 5;
            //this.pnlPointCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // pnlPointTopBar
            // 
            this.pnlPointTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.pnlPointTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPointTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlPointTopBar.Name = "pnlPointTopBar";
            this.pnlPointTopBar.Size = new System.Drawing.Size(320, 6);
            this.pnlPointTopBar.TabIndex = 0;
            // 
            // lblPointIcon
            // 
            this.lblPointIcon.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.lblPointIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblPointIcon.Location = new System.Drawing.Point(20, 30);
            this.lblPointIcon.Name = "lblPointIcon";
            this.lblPointIcon.Size = new System.Drawing.Size(100, 100);
            this.lblPointIcon.TabIndex = 1;
            this.lblPointIcon.Text = "🎟️";
            this.lblPointIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointTitle
            // 
            this.lblPointTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPointTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblPointTitle.Location = new System.Drawing.Point(130, 25);
            this.lblPointTitle.Name = "lblPointTitle";
            this.lblPointTitle.Size = new System.Drawing.Size(180, 28);
            this.lblPointTitle.TabIndex = 2;
            this.lblPointTitle.Text = "Check-in hôm nay";
            this.lblPointTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPointCount
            // 
            this.lblPointCount.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblPointCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPointCount.Location = new System.Drawing.Point(130, 55);
            this.lblPointCount.Name = "lblPointCount";
            this.lblPointCount.Size = new System.Drawing.Size(180, 60);
            this.lblPointCount.TabIndex = 3;
            this.lblPointCount.Text = "0";
            this.lblPointCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPointTrend
            // 
            this.lblPointTrend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPointTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblPointTrend.Location = new System.Drawing.Point(130, 120);
            this.lblPointTrend.Name = "lblPointTrend";
            this.lblPointTrend.Size = new System.Drawing.Size(180, 20);
            this.lblPointTrend.TabIndex = 4;
            this.lblPointTrend.Text = "📈 +5% so với hôm qua";
            this.lblPointTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableContainer.BackColor = System.Drawing.Color.White;
            this.pnlTableContainer.Controls.Add(this.pnlPagination);
            this.pnlTableContainer.Controls.Add(this.dgvLatestBooks);
            this.pnlTableContainer.Controls.Add(this.lblTableTitle);
            this.pnlTableContainer.Location = new System.Drawing.Point(40, 290);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Padding = new System.Windows.Forms.Padding(20);
            this.pnlTableContainer.Size = new System.Drawing.Size(1020, 380);
            this.pnlTableContainer.TabIndex = 6;
            //this.pnlTableContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTableTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(282, 32);
            this.lblTableTitle.TabIndex = 0;
            this.lblTableTitle.Text = "Sách mới thêm gần đây";
            // 
            // dgvLatestBooks
            // 
            this.dgvLatestBooks.AllowUserToAddRows = false;
            this.dgvLatestBooks.AllowUserToDeleteRows = false;
            this.dgvLatestBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLatestBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLatestBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvLatestBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLatestBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLatestBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            
            this.dgvLatestBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLatestBooks.ColumnHeadersHeight = 45;
            this.dgvLatestBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            
            this.dgvLatestBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLatestBooks.EnableHeadersVisualStyles = false;
            this.dgvLatestBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvLatestBooks.Location = new System.Drawing.Point(20, 65);
            this.dgvLatestBooks.Name = "dgvLatestBooks";
            this.dgvLatestBooks.ReadOnly = true;
            this.dgvLatestBooks.RowHeadersVisible = false;
            this.dgvLatestBooks.RowHeadersWidth = 51;
            this.dgvLatestBooks.RowTemplate.Height = 45;
            this.dgvLatestBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLatestBooks.Size = new System.Drawing.Size(980, 260);
            this.dgvLatestBooks.TabIndex = 1;
            // 
            // pnlPagination
            // 
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Controls.Add(this.lblPagination);
            this.pnlPagination.Location = new System.Drawing.Point(20, 330);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(980, 40);
            this.pnlPagination.TabIndex = 2;
            // 
            // lblPagination
            // 
            this.lblPagination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPagination.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPagination.ForeColor = System.Drawing.Color.Gray;
            this.lblPagination.Location = new System.Drawing.Point(0, 0);
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Size = new System.Drawing.Size(980, 40);
            this.lblPagination.TabIndex = 0;
            this.lblPagination.Text = "⏮  <   1   2   >  ⏭";
            this.lblPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlTableContainer);
            this.Controls.Add(this.pnlPointCard);
            this.Controls.Add(this.pnlEmpCard);
            this.Controls.Add(this.pnlBookCard);
            this.Controls.Add(this.lblUserProfile);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.lblHeaderTitle);
            this.Name = "F_Dashboard";
            this.Text = "📊 Dashboard - Tổng quan hệ thống";
            this.Load += new System.EventHandler(this.F_Dashboard_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlBookCard.ResumeLayout(false);
            this.pnlEmpCard.ResumeLayout(false);
            this.pnlPointCard.ResumeLayout(false);
            this.pnlTableContainer.ResumeLayout(false);
            this.pnlTableContainer.PerformLayout();
            this.pnlPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLatestBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}