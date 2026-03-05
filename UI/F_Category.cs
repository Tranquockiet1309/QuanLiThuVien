using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Data;
using DTO;
using Services;

namespace UI
{
    public partial class F_Category : Form
    {
        private readonly CategoryService categoryService;
        private string selectedImageFile = ""; // chỉ lưu tên file ảnh

        // Constructor mặc định
        public F_Category() : this(new LibraryContext()) { }

        // Constructor có tham số context
        public F_Category(LibraryContext dbContext)
        {
            InitializeComponent();
            categoryService = new CategoryService(dbContext);
        }

        private void F_Category_Load(object sender, EventArgs e)
        {
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv.MultiSelect = false;
            gv.ReadOnly = true;
            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            LoadData();
        }

        // ------------------------------
        // LOAD DATA GRID
        // ------------------------------
        private void LoadData()
        {
            gv.DataSource = categoryService.GetAll();

            gv.Columns["CateId"].HeaderText = "Mã loại";
            gv.Columns["CateName"].HeaderText = "Tên loại";
            gv.Columns["Description"].HeaderText = "Mô tả";
            gv.Columns["Img"].HeaderText = "Ảnh";
            gv.Columns["CreatedAt"].HeaderText = "Ngày tạo";
            gv.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // ------------------------------
        // CLEAR FORM
        // ------------------------------
        private void ClearForm()
        {
            txtId.Enabled = true;
            txtId.Clear();
            txtName.Clear();
            txtDesc.Clear();
            picCate.Image = null;
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

            if (gv.CurrentRow.DataBoundItem is CategoryDTO c)
            {
                txtId.Text = c.CateId.ToString();
                txtName.Text = c.CateName;
                txtDesc.Text = c.Description;

                selectedImageFile = c.Img ?? "";
                string imgPath = Path.Combine(Application.StartupPath, "Images", selectedImageFile);

                picCate.Image = File.Exists(imgPath) ? Image.FromFile(imgPath) : null;
            }

            txtId.Enabled = false;
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        // ------------------------------
        // ADD CATEGORY
        // ------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new CategoryDTO
                {
                    CateName = txtName.Text.Trim(),
                    Description = txtDesc.Text.Trim(),
                    Img = selectedImageFile
                };

                var result = categoryService.Add(dto);
                MessageBox.Show(result.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.Success)
                {
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------
        // UPDATE CATEGORY
        // ------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new CategoryDTO
                {
                    CateId = int.Parse(txtId.Text.Trim()),
                    CateName = txtName.Text.Trim(),
                    Description = txtDesc.Text.Trim(),
                    Img = selectedImageFile
                };

                var result = categoryService.Update(dto);
                MessageBox.Show(result.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.Success)
                {
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật loại sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------
        // DELETE CATEGORY
        // ------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gv.CurrentRow == null) return;

            int id = (int)gv.CurrentRow.Cells["CateId"].Value;

            if (MessageBox.Show("Bạn có chắc muốn xóa loại sách này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = categoryService.Delete(id);
                MessageBox.Show(result.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.Success)
                {
                    LoadData();
                    ClearForm();
                }
            }
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

        // ------------------------------
        // EXPORT JSON (tùy chọn)
        // ------------------------------
        private void btnExport_Click(object sender, EventArgs e)
        {
            var categories = categoryService.GetAll();
            string json = System.Text.Json.JsonSerializer.Serialize(categories,
                new System.Text.Json.JsonSerializerOptions
                {
                    WriteIndented = true
                });
            rt_json.Text = json;
        }

        // ------------------------------
        // CHỌN ẢNH 
        // ------------------------------
        private void picCate_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ảnh (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string folder = Path.Combine(Application.StartupPath, "Images");
                Directory.CreateDirectory(folder);

                string fileName = Path.GetFileName(ofd.FileName);
                string destPath = Path.Combine(folder, fileName);

                try
                {
                    File.Copy(ofd.FileName, destPath, true);
                    selectedImageFile = fileName; // ✅ chỉ lưu tên file
                    picCate.Image = Image.FromFile(destPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sao chép ảnh: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ------------------------------
        // XÓA ẢNH (giống F_Book)
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
                        picCate.Image?.Dispose();
                        picCate.Image = null;

                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        File.Delete(filePath);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa ảnh (file đang được sử dụng).",
                            "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            selectedImageFile = "";
            picCate.Image = null;
        }
    }
}
