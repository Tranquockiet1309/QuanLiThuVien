using System;
using System.Linq;
using System.Windows.Forms;
using Data;
using Services;

namespace UI
{
    public partial class F_Dashboard : Form
    {
        private readonly LibraryContext _db;
        private readonly BookService _bookService;
        private readonly UserService _userService;
        private readonly PointsLedgerService _pointsLedgerService;

        public F_Dashboard()
        {
            InitializeComponent();

            _db = new LibraryContext();
            _bookService = new BookService(_db);
            _userService = new UserService(_db);
            _pointsLedgerService = new PointsLedgerService(_db);
        }

        private void F_Dashboard_Load(object sender, EventArgs e)
        {
            LoadStatistics();
            LoadLatestBooks();
        }

        // ============================================
        //  THỐNG KÊ
        // ============================================
        private void LoadStatistics()
        {
            // Kiểm tra số lượng sách
            var bookCount = _bookService.GetAll().Count;
            lblBookCount.Text = $"{bookCount}";

            // Kiểm tra số lượng người dùng
            var userCount = _userService.GetAll().Count;
            lblEmpCount.Text = $"{userCount}";
            // Kiểm tra số lượng người dùng
            var pointCount = _pointsLedgerService.GetAll().Count;
            lblPointCount.Text = $"{pointCount}";
        }


        // ============================================
        //  LOAD 5 SÁCH MỚI NHẤT
        // ============================================
        private void LoadLatestBooks()
        {
            var books = _bookService.GetAll()
                .OrderByDescending(b => b.BookId)
                .Take(5)
                .ToList();

            dgvLatestBooks.AutoGenerateColumns = false;
            dgvLatestBooks.Columns.Clear();

            dgvLatestBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BookId",
                HeaderText = "Mã",
                DataPropertyName = "BookId",
                Width = 60
            });

            dgvLatestBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BookName",
                HeaderText = "Tên sách",
                DataPropertyName = "BookName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvLatestBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Thể loại",
                DataPropertyName = "CategoryName",
                Width = 140
            });

            dgvLatestBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PublisherName",
                HeaderText = "NXB",
                DataPropertyName = "PublisherName",
                Width = 140
            });

            dgvLatestBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Giá",
                DataPropertyName = "Price",
                Width = 100
            });

            dgvLatestBooks.RowHeadersVisible = false;
            dgvLatestBooks.DataSource = books;
        }

        
    }
}
