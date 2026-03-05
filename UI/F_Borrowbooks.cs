using System;
using System.Linq;
using System.Windows.Forms;
using Data;
using Services;

namespace UI
{
    public partial class F_Borrowbooks : Form
    {
        private readonly LibraryContext db;
        private readonly BorrowbooksService borrowService;

        // ✅ Constructor mặc định – tự tạo DbContext
        public F_Borrowbooks() : this(new LibraryContext()) { }

        public F_Borrowbooks(LibraryContext context)
        {
            InitializeComponent();
            db = context;
            borrowService = new BorrowbooksService(db);
        }
        private void F_Borrowbooks_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void F_Borrowbooks_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvBorrowbooks.DataSource = borrowService.GetAll();

            dgvBorrowbooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowbooks.ReadOnly = true;
            dgvBorrowbooks.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvBorrowbooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowbooks.MultiSelect = false;
            dgvBorrowbooks.RowHeadersVisible = false;
            // (tuỳ chọn) đặt HeaderText tiếng Việt
            if (dgvBorrowbooks.Columns["BorrowId"] != null) dgvBorrowbooks.Columns["BorrowId"].HeaderText = "Mã phiếu";
            if (dgvBorrowbooks.Columns["UserId"] != null) dgvBorrowbooks.Columns["UserId"].HeaderText = "Mã người dùng";
            if (dgvBorrowbooks.Columns["UserName"] != null) dgvBorrowbooks.Columns["UserName"].HeaderText = "Người mượn";
            if (dgvBorrowbooks.Columns["BookId"] != null) dgvBorrowbooks.Columns["BookId"].HeaderText = "Mã sách";
            if (dgvBorrowbooks.Columns["BookName"] != null) dgvBorrowbooks.Columns["BookName"].HeaderText = "Tên sách";
            if (dgvBorrowbooks.Columns["BorrowDate"] != null) dgvBorrowbooks.Columns["BorrowDate"].HeaderText = "Ngày mượn";
            if (dgvBorrowbooks.Columns["ReturnDate"] != null) dgvBorrowbooks.Columns["ReturnDate"].HeaderText = "Ngày trả";
            if (dgvBorrowbooks.Columns["IsReturned"] != null) dgvBorrowbooks.Columns["IsReturned"].HeaderText = "Đã trả";

            dgvBorrowbooks.DataBindingComplete -= Dgv_DataBindingComplete;
            dgvBorrowbooks.DataBindingComplete += Dgv_DataBindingComplete;
        }
        

        private void Dgv_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBorrowbooks.ClearSelection();
            dgvBorrowbooks.CurrentCell = null;  // đảm bảo không có CurrentCell
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out var userId) || !int.TryParse(txtBookId.Text, out var bookId))
            {
                MessageBox.Show("Vui lòng nhập đúng Mã người dùng và Mã sách!");
                return;
            }

            var result = borrowService.BorrowBook(userId, bookId);
            MessageBox.Show(result.Message, "Thông báo",
                MessageBoxButtons.OK,
                result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (result.Success) LoadData();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Chỉ trả khi người dùng thật sự chọn 1 dòng
            if (dgvBorrowbooks.SelectedRows.Count == 1)
            {
                var row = dgvBorrowbooks.SelectedRows[0];
                int borrowId = (int)row.Cells["BorrowId"].Value;

                var rs1 = borrowService.ReturnBook(borrowId);
                MessageBox.Show(rs1.Message, "Thông báo", MessageBoxButtons.OK,
                    rs1.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (rs1.Success) LoadData();
                return;
            }

            // Không chọn dòng -> fallback theo ô nhập
            if (!int.TryParse(txtUserId.Text, out var userId) || !int.TryParse(txtBookId.Text, out var bookId))
            {
                MessageBox.Show("Vui lòng nhập đúng Mã người dùng và Mã sách!");
                return;
            }

            var rs2 = borrowService.ReturnByUserAndBook(userId, bookId);
            MessageBox.Show(rs2.Message, "Thông báo", MessageBoxButtons.OK,
                rs2.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (rs2.Success) LoadData();
        }



        // ✅ Mở form tìm/chọn sách (tái sử dụng F_TimKiemSach)
        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            using var frm = new F_TimKiemSach(db, isSelectionMode: true); // dùng db, không phải _db
            if (frm.ShowDialog(this) == DialogResult.OK && frm.SelectedBook != null)
            {
                txtBookId.Text = frm.SelectedBook.BookId.ToString();
                //(tuỳ chọn) hiện tên sách ra label:
                lblBookName.Text = frm.SelectedBook.BookName;
            }
        }
    }
}
