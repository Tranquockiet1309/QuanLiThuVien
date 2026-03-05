using System;
using System.Drawing;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows.Forms;
using Data;
using DTO;
using Services;

namespace UI
{
    public partial class F_Publisher : Form
    {
        private readonly PublisherService publisherService;
        private string selectedImagePath = "";

        // ✅ Constructor có tham số
        public F_Publisher(LibraryContext dbContext)
        {
            InitializeComponent();
            publisherService = new PublisherService(dbContext);
        }

        // ✅ Constructor mặc định
        public F_Publisher() : this(new LibraryContext()) { }

        private void F_Publisher_Load(object sender, EventArgs e)
        {
            dgvPublisher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPublisher.MultiSelect = false;
            dgvPublisher.ReadOnly = true;
            dgvPublisher.AllowUserToAddRows = false;
            dgvPublisher.AllowUserToDeleteRows = false;

            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            LoadData();
        }

        private void LoadData()
        {
            var list = publisherService.GetAll();
            dgvPublisher.DataSource = null;
            dgvPublisher.DataSource = list;

            dgvPublisher.Columns["PublisherId"].HeaderText = "Mã NXB";
            dgvPublisher.Columns["PublisherName"].HeaderText = "Tên NXB";
            dgvPublisher.Columns["Address"].HeaderText = "Địa chỉ";
            dgvPublisher.Columns["Phone"].HeaderText = "SĐT";
            dgvPublisher.Columns["Logo"].HeaderText = "Logo";
            dgvPublisher.Columns["CreatedAt"].HeaderText = "Ngày tạo";
            dgvPublisher.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void ClearForm()
        {
            txtId.Enabled = true;
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            picLogo.Image = null;
            selectedImagePath = "";

            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        private void dgvPublisher_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPublisher.CurrentRow == null) return;

            if (dgvPublisher.CurrentRow.DataBoundItem is PublisherDTO p)
            {
                // Lấy thông tin của Publisher và điền vào các ô input
                txtId.Text = p.PublisherId.ToString();
                txtName.Text = p.PublisherName;
                txtAddress.Text = p.Address;
                txtPhone.Text = p.Phone;
                txtEmail.Text = p.Email;

                // Kiểm tra nếu có logo và tồn tại trên ổ đĩa
                if (!string.IsNullOrEmpty(p.Logo))
                {
                    string logoPath = Path.Combine(Application.StartupPath, "Images", p.Logo);

                    // Kiểm tra nếu ảnh tồn tại thì hiển thị
                    if (File.Exists(logoPath))
                    {
                        try
                        {
                            picLogo.Image = Image.FromFile(logoPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể hiển thị ảnh logo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            picLogo.Image = null;
                        }
                    }
                    else
                    {
                        picLogo.Image = null; // Nếu ảnh không tồn tại, xóa ảnh cũ
                    }
                }
                else
                {
                    picLogo.Image = null; // Nếu không có logo, xóa ảnh cũ
                }

                // Cập nhật biến selectedImagePath để lưu tên ảnh vào CSDL sau này
                selectedImagePath = p.Logo ?? ""; // Lưu tên file ảnh (nếu có)
            }

            // Vô hiệu hóa ô Id để không thể chỉnh sửa
            txtId.Enabled = false;

            // Hiển thị các nút Update và Delete
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new PublisherDTO
                {
                    PublisherName = txtName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Logo = selectedImagePath  // Chỉ lưu tên ảnh
                };

                var result = publisherService.Add(dto);
                MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.Success)
                {
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm NXB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void F_Publisher_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null; // bỏ focus khi form hiện ra
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var current = dgvPublisher.CurrentRow?.DataBoundItem as PublisherDTO;
                string oldLogo = current?.Logo ?? "";

                string logoToSave;
                if (string.IsNullOrEmpty(selectedImagePath))
                {
                    logoToSave = null; // Nếu không chọn ảnh mới thì để logo là null
                }
                else
                {
                    logoToSave = selectedImagePath; // Lưu tên ảnh nếu có ảnh mới
                }

                var dto = new PublisherDTO
                {
                    PublisherId = int.Parse(txtId.Text.Trim()),
                    PublisherName = txtName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Logo = logoToSave  // Chỉ lưu tên ảnh
                };

                var result = publisherService.Update(dto);
                MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.Success)
                {
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật NXB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPublisher.CurrentRow == null) return;
            int id = (int)dgvPublisher.CurrentRow.Cells["PublisherId"].Value;

            if (MessageBox.Show("Bạn có chắc muốn xóa nhà xuất bản này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = publisherService.Delete(id);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ảnh (*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofd.FileName); // Lấy tên tệp ảnh
                string folderPath = Path.Combine(Application.StartupPath, "Images");
                Directory.CreateDirectory(folderPath); // Tạo thư mục Images nếu chưa có

                string destPath = Path.Combine(folderPath, fileName); // Đặt đường dẫn lưu tệp

                try
                {
                    // Giải phóng tài nguyên hình ảnh cũ trước khi sao chép tệp
                    if (picLogo.Image != null)
                    {
                        picLogo.Image.Dispose();
                        picLogo.Image = null;
                    }

                    // Sao chép tệp ảnh vào thư mục Images
                    File.Copy(ofd.FileName, destPath, true);
                    selectedImagePath = fileName; // Chỉ lưu tên ảnh, không lưu đường dẫn đầy đủ
                    picLogo.Image = Image.FromFile(destPath);  // Hiển thị ảnh mới trong PictureBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể sao chép ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu đường dẫn ảnh không trống và tệp ảnh tồn tại
                if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                {
                    // Giải phóng bộ nhớ của hình ảnh trong PictureBox trước khi xóa
                    picLogo.Image?.Dispose();
                    picLogo.Image = null;

                    // Xóa ảnh khỏi thư mục Images
                    File.Delete(selectedImagePath);
                }

                // Reset lại đường dẫn ảnh
                selectedImagePath = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            var list = publisherService.GetAll();
            string json = JsonSerializer.Serialize(list,
                new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                });
            rt_json.Text = json;
        }

       
    }
}
