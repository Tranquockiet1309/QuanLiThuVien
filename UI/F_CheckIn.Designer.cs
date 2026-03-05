// F_CheckIn.Designer (gộp chung cho tiện – nếu bạn tách partial file, giữ nguyên nội dung)
namespace UI
{
    partial class F_CheckIn
    {
        private System.ComponentModel.IContainer components = null!;
        private Label labelTitle;
        private Label labelUserId;
        private TextBox txtUserId;
        private Label labelNote;
        private TextBox txtNote;
        private Button btnCheckIn;
        private Label labelUser;
        private Label lblUserName;
        private Label labelTotal;
        private Label lblTotalPoints;
        private DataGridView gv;
        private Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            labelTitle = new Label();
            labelUserId = new Label();
            txtUserId = new TextBox();
            labelNote = new Label();
            txtNote = new TextBox();
            btnCheckIn = new Button();
            labelUser = new Label();
            lblUserName = new Label();
            labelTotal = new Label();
            lblTotalPoints = new Label();
            gv = new DataGridView();
            lblStatus = new Label();

            SuspendLayout();

            // Form
            this.Text = "Check-in thư viện";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(740, 520);
            this.Load += F_CheckIn_Load;

            // Title
            labelTitle.Text = "CHECK-IN THƯ VIỆN";
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(20, 15);

            // UserId
            labelUserId.Text = "Mã người dùng:";
            labelUserId.AutoSize = true;
            labelUserId.Location = new Point(22, 60);
            txtUserId.Location = new Point(140, 56);
            txtUserId.Size = new Size(140, 27);
            txtUserId.KeyDown += TxtUserId_KeyDown;

            // Note
            labelNote.Text = "Ghi chú:";
            labelNote.AutoSize = true;
            labelNote.Location = new Point(300, 60);
            txtNote.Location = new Point(360, 56);
            txtNote.Size = new Size(230, 27);

            // Button CheckIn
            btnCheckIn.Text = "Check-in";
            btnCheckIn.Location = new Point(610, 55);
            btnCheckIn.Size = new Size(100, 30);
            btnCheckIn.Click += BtnCheckIn_Click;

            // User info
            labelUser.Text = "Người dùng:";
            labelUser.AutoSize = true;
            labelUser.Location = new Point(22, 100);
            lblUserName.Text = "(chưa có dữ liệu)";
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserName.Location = new Point(110, 100);

            // Total points
            labelTotal.Text = "Tổng điểm:";
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(22, 125);
            lblTotalPoints.Text = "0";
            lblTotalPoints.AutoSize = true;
            lblTotalPoints.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalPoints.ForeColor = Color.RoyalBlue;
            lblTotalPoints.Location = new Point(110, 123);

            // Grid
            gv.Location = new Point(20, 160);
            gv.Size = new Size(690, 320);
            gv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // Status
            lblStatus.Text = "";
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(22, 485);
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Add controls
            this.Controls.Add(labelTitle);
            this.Controls.Add(labelUserId);
            this.Controls.Add(txtUserId);
            this.Controls.Add(labelNote);
            this.Controls.Add(txtNote);
            this.Controls.Add(btnCheckIn);
            this.Controls.Add(labelUser);
            this.Controls.Add(lblUserName);
            this.Controls.Add(labelTotal);
            this.Controls.Add(lblTotalPoints);
            this.Controls.Add(gv);
            this.Controls.Add(lblStatus);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
