using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Data;
using DTO;
using Services;

namespace UI
{
    public partial class F_TimKiemLoaiNXB : Form
    {
        private readonly LibraryContext _db;
        private readonly BookService _bookService;

        private List<BookDTO> _currentList = new();

        public F_TimKiemLoaiNXB() : this(new LibraryContext()) { }

        public F_TimKiemLoaiNXB(LibraryContext db)
        {
            InitializeComponent();
            _db = db;
            _bookService = new BookService(_db);
        }

        private void F_TimKiemLoaiNXB_Load(object sender, EventArgs e)
        {
            dgvKetQua.AutoGenerateColumns = false;
            SetupGrid();
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cbType.Items.Add("Loại sách");
            cbType.Items.Add("Nhà xuất bản");
            cbType.SelectedIndex = 0;

            lblTitle.Text = "📚 Tìm kiếm theo Loại sách hoặc Nhà xuất bản";

            LoadData();
        }

        // ==================================================
        // TẠO CỘT GRIDVIEW
        // ==================================================
        private void SetupGrid()
        {
            dgvKetQua.Columns.Clear();

            dgvKetQua.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BookId",
                HeaderText = "Mã sách",
                DataPropertyName = "BookId",
                Width = 90
            });

           
            dgvKetQua.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Ảnh",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 90
            });

            dgvKetQua.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BookName",
                HeaderText = "Tên sách",
                DataPropertyName = "BookName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvKetQua.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Loại sách",
                DataPropertyName = "CategoryName",
                Width = 140
            });

            dgvKetQua.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PublisherName",
                HeaderText = "Nhà XB",
                DataPropertyName = "PublisherName",
                Width = 140
            });

            dgvKetQua.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Giá",
                DataPropertyName = "Price",
                Width = 100
            });

            dgvKetQua.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "Mô tả",
                DataPropertyName = "Description",
                Width = 220
            });

            dgvKetQua.RowHeadersVisible = false;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.ReadOnly = true;
        }

        // ==================================================
        // LOAD TẤT CẢ + SEARCH
        // ==================================================
        private void LoadData(string? keyword = null)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                BindAndPaint(_bookService.GetAll());
                return;
            }

            if (cbType.SelectedItem.ToString() == "Loại sách")
                BindAndPaint(_bookService.SearchByCategoryName(keyword));
            else
                BindAndPaint(_bookService.SearchByPublisherName(keyword));
        }

        // ==================================================
        // BIND + LOAD ẢNH
        // ==================================================
        private void BindAndPaint(List<BookDTO> data)
        {
            _currentList = data;

            dgvKetQua.DataSource = null;
            dgvKetQua.DataSource = _currentList;

            foreach (DataGridViewRow row in dgvKetQua.Rows)
            {
                if (row.DataBoundItem is BookDTO b)
                {
                    Image? img = LoadImageSafe(b.FileImg);
                    row.Cells["Image"].Value = img;
                }
            }

            lblTotal.Text = $"Kết quả: {dgvKetQua.Rows.Count} sách";
        }

        // ==================================================
        // LOAD ẢNH KHÔNG KHÓA FILE
        // ==================================================
        private Image? LoadImageSafe(string? fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            string fullPath = Path.Combine(Application.StartupPath, "Images", fileName);

            if (!File.Exists(fullPath))
                return null;

            try
            {
                using var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                return Image.FromStream(fs);
            }
            catch
            {
                return null;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa!", "Thông báo");
                return;
            }

            LoadData(keyword);
        }

        private void btnXemJson_Click(object sender, EventArgs e)
        {
            if (_currentList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }

            rt_json.Text = JsonSerializer.Serialize(_currentList,
                new JsonSerializerOptions { WriteIndented = true });
        }

        private void btnXuatJson_Click(object sender, EventArgs e)
        {
            if (_currentList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "JSON|*.json",
                FileName = "KetQua_Loai_NXB.json"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName,
                    JsonSerializer.Serialize(_currentList,
                        new JsonSerializerOptions { WriteIndented = true }));

                MessageBox.Show("Xuất JSON thành công!");
            }
        }
    }
}
