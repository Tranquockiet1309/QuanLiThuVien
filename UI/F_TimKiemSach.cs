using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using Data;
using DTO;
using Services;

namespace UI
{
    public partial class F_TimKiemSach : Form
    {
        private readonly LibraryContext _db;
        private readonly BookService _bookService;
        private readonly bool _isSelectionMode;

        private List<BookDTO> _currentList = new();

        public BookDTO? SelectedBook { get; private set; }

        public F_TimKiemSach() : this(new LibraryContext(), false) { }

        public F_TimKiemSach(bool isSelectionMode) : this(new LibraryContext(), isSelectionMode) { }

        public F_TimKiemSach(LibraryContext context, bool isSelectionMode = false)
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            _db = context;
            _bookService = new BookService(_db);
            _isSelectionMode = isSelectionMode;
        }

        private void F_TimKiemSach_Load(object sender, EventArgs e)
        {
            dgvKetQua.AutoGenerateColumns = false;
            SetupGrid();

            if (_isSelectionMode)
            {
                Text = "Chọn sách";
                lblTitle.Text = "📚 Chọn sách để mượn (double-click để chọn)";
                btnPick.Visible = true;
            }
            else
            {
                Text = "Tìm kiếm sách";
                lblTitle.Text = "🔍 Tìm kiếm sách theo MÃ hoặc TÊN";
                btnPick.Visible = false;
            }

            LoadData();
        }

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
            dgvKetQua.MultiSelect = false;
            dgvKetQua.ReadOnly = true;

            dgvKetQua.DoubleClick += dgvKetQua_DoubleClick;
        }

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

            lblCount.Text = $"Kết quả: {dgvKetQua.Rows.Count} sách";
        }
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


        // ----------------- LoadData() sửa theo Search mới -----------------
        private void LoadData(string? keyword = null)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                BindAndPaint(_bookService.GetAll());
                return;
            }

            // Search chỉ còn tìm theo ID + Tên
            var list = _bookService.Search(keyword);
            BindAndPaint(list);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtKeyword.Text.Trim());
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void dgvKetQua_DoubleClick(object? sender, EventArgs e)
        {
            if (_isSelectionMode)
                PickCurrent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            PickCurrent();
        }

        private void PickCurrent()
        {
            if (dgvKetQua.CurrentRow?.DataBoundItem is BookDTO b)
            {
                SelectedBook = b;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnExportJson_Click(object sender, EventArgs e)
        {
            if (_currentList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "JSON|*.json",
                FileName = "Books.json"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName,
                    JsonSerializer.Serialize(_currentList, new JsonSerializerOptions
                    {
                        WriteIndented = true
                    }));

                MessageBox.Show("Xuất JSON thành công!");
            }
        }

        private void btnXemJson_Click(object sender, EventArgs e)
        {
            if (_currentList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }

            rt_json.Text = JsonSerializer.Serialize(_currentList,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });
        }
    }
}
