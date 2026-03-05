
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI
{
    partial class F_Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            picCate = new PictureBox();
            rt_json = new RichTextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            button1 = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            txtDesc = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            gv = new DataGridView();
            btnRefresh = new Button();
            btnExport = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCate).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(picCate);
            panel1.Controls.Add(rt_json);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 519);
            panel1.TabIndex = 0;
            // 
            // picCate
            // 
            picCate.BorderStyle = BorderStyle.FixedSingle;
            picCate.Location = new Point(87, 237);
            picCate.Name = "picCate";
            picCate.Size = new Size(266, 132);
            picCate.SizeMode = PictureBoxSizeMode.Zoom;
            picCate.TabIndex = 0;
            picCate.TabStop = false;
            picCate.Click += picCate_Click;
            // 
            // rt_json
            // 
            rt_json.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rt_json.Location = new Point(3, 417);
            rt_json.Name = "rt_json";
            rt_json.Size = new Size(350, 182);
            rt_json.TabIndex = 6;
            rt_json.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Location = new Point(223, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(64, 39);
            btnSave.TabIndex = 5;
            btnSave.Text = "Create";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(151, 372);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(70, 39);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(293, 372);
            button1.Name = "button1";
            button1.Size = new Size(70, 39);
            button1.TabIndex = 5;
            button1.Text = "Del Img";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDeleteImg_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(78, 372);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 39);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.Location = new Point(6, 372);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(70, 39);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(12, 204);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(341, 27);
            txtDesc.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 151);
            txtName.Name = "txtName";
            txtName.Size = new Size(341, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(13, 104);
            txtId.Name = "txtId";
            txtId.Size = new Size(341, 27);
            txtId.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(12, 234);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 0;
            label6.Text = "File ảnh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 0;
            label5.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên danh mục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã danh mục";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(78, 44);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin danh mục";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(gv);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnExport);
            panel2.Location = new Point(375, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 519);
            panel2.TabIndex = 1;
            // 
            // gv
            // 
            gv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv.Location = new Point(3, 55);
            gv.Name = "gv";
            gv.RowHeadersWidth = 51;
            gv.Size = new Size(417, 461);
            gv.TabIndex = 6;
            gv.DoubleClick += gv_DoubleClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Silver;
            btnRefresh.Location = new Point(3, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 39);
            btnRefresh.TabIndex = 5;
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
            btnExport.TabIndex = 5;
            btnExport.Text = "Xuất Json";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // F_Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "F_Category";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_App3";
            Load += F_Category_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCate).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox picCate;
        private TextBox txtDesc;
        private TextBox txtName;
        private TextBox txtId;
        private RichTextBox rt_json;
        private Button btnSave;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnExport;
        private DataGridView gv;
        private Button button1;
    }
}