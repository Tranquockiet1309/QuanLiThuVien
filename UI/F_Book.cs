using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DTO;
using Services;
using Data;

namespace UI
{
    public partial class F_Book : Form
    {
        private readonly BookService bookService;
        private readonly CategoryService categoryService;
        private readonly PublisherService publisherService;

        private string selectedImageFile = ""; // chỉ lưu tên file ảnh

        public F_Book() : this(new LibraryContext()) { }

        public F_Book(LibraryContext db)
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            bookService = new BookService(db);
            categoryService = new CategoryService(db);
            publisherService = new PublisherService(db);
        }

        private void F_Book_Load(object sender, EventArgs e)
        {
            gv.ReadOnly = true;
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv.AllowUserToAddRows = false;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            LoadComboData();
            LoadData();
        }

        // ------------------------------
        // LOAD COMBOBOX 
        // ------------------------------
        private void LoadComboData()
        {
            cbCategory.DataSource = categoryService.GetAll();
            cbCategory.DisplayMember = "CateName";
            cbCategory.ValueMember = "CateId";
            cbCategory.SelectedIndex = -1;

            cbPublisher.DataSource = publisherService.GetAll();
            cbPublisher.DisplayMember = "PublisherName";
            cbPublisher.ValueMember = "PublisherId";
            cbPublisher.SelectedIndex = -1;
        }

        // ------------------------------
        // LOAD DATA GRID
        // ------------------------------
        private void LoadData()
        {
            gv.DataSource = bookService.GetAll();
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv.Columns["CategoryId"].Visible = false;
            gv.Columns["PublisherId"].Visible = false;
            gv.Columns["CreatedAt"].Visible = false;
            gv.Columns["UpdatedAt"].Visible = false;
        }

        // ------------------------------
        // CLEAR FORM
        // ------------------------------
        private void ClearForm()
        {
            txtId.Enabled = true;

            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtDesc.Text = "";
            cbCategory.SelectedIndex = -1;
            cbPublisher.SelectedIndex = -1;

            picBook.Image = null;
            selectedImageFile = "";

            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        // ------------------------------
        // DOUBLE CLICK GRID → LOAD FORM
        // ------------------------------
        private void gv_DoubleClick(object sender, EventArgs e)
        {
            if (gv.CurrentRow == null) return;

            if (gv.CurrentRow.DataBoundItem is BookDTO b)
            {
                txtId.Text = b.BookId.ToString();
                txtName.Text = b.BookName;
                txtPrice.Text = b.Price.ToString();
                txtDesc.Text = b.Description;
                cbCategory.SelectedValue = b.CategoryId;
                cbPublisher.SelectedValue = b.PublisherId ?? -1;

                selectedImageFile = b.FileImg ?? "";

                string imgPath = Path.Combine(Application.StartupPath, "Images", selectedImageFile);
                picBook.Image = File.Exists(imgPath) ? Image.FromFile(imgPath) : null;
            }

            txtId.Enabled = false;
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        // ------------------------------
        // ADD BOOK
        // ------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            var b = new BookDTO
            {
                BookName = txtName.Text.Trim(),
                CategoryId = (int)cbCategory.SelectedValue,
                PublisherId = (int?)cbPublisher.SelectedValue,
                Price = double.TryParse(txtPrice.Text, out var p) ? p : 0,
                Description = txtDesc.Text.Trim(),
                FileImg = selectedImageFile
            };

            var result = bookService.Add(b);
            MessageBox.Show(result.Message);

            if (result.Success)
            {
                LoadData();
                ClearForm();
            }
        }

        // ------------------------------
        // UPDATE BOOK
        // ------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var b = new BookDTO
            {
                BookId = int.Parse(txtId.Text),
                BookName = txtName.Text.Trim(),
                CategoryId = (int)cbCategory.SelectedValue,
                PublisherId = (int?)cbPublisher.SelectedValue,
                Price = double.TryParse(txtPrice.Text, out var p) ? p : 0,
                Description = txtDesc.Text.Trim(),
                FileImg = selectedImageFile
            };

            var result = bookService.Update(b);
            MessageBox.Show(result.Message);

            if (result.Success)
            {
                LoadData();
                ClearForm();
            }
        }

        // ------------------------------
        // DELETE BOOK
        // ------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gv.CurrentRow == null) return;

            int id = (int)gv.CurrentRow.Cells["BookId"].Value;

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var result = bookService.Delete(id);
                MessageBox.Show(result.Message);

                if (result.Success)
                {
                    LoadData();
                    ClearForm();
                }
            }
        }

        // ------------------------------
        // CHỌN ẢNH
        // ------------------------------
        private void picBook_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ảnh (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // thư mục /Images
                string folder = Path.Combine(Application.StartupPath, "Images");
                Directory.CreateDirectory(folder);

                string fileName = Path.GetFileName(ofd.FileName);
                string destPath = Path.Combine(folder, fileName);

                File.Copy(ofd.FileName, destPath, true);

                selectedImageFile = fileName;
                picBook.Image = Image.FromFile(destPath);
            }
        }

        // ------------------------------
        // XÓA ẢNH
        // ------------------------------
        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedImageFile))
            {
                string filePath = Path.Combine(Application.StartupPath, "Images", selectedImageFile);

                if (File.Exists(filePath))
                {
                    try
                    {
                        //Giải phóng PictureBox trước khi xóa
                        picBook.Image?.Dispose();
                        picBook.Image = null;

                        GC.Collect(); // ép garbage collector giải phóng file
                        GC.WaitForPendingFinalizers();

                        File.Delete(filePath);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa ảnh (file đang được sử dụng).");
                        return;
                    }
                }
            }

            selectedImageFile = "";
            picBook.Image = null;
        }


        // ------------------------------
        // CANCEL
        // ------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // ------------------------------
        // REFRESH
        // ------------------------------
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
