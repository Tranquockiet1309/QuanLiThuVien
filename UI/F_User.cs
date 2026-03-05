using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows.Forms;
using Data;
using DTO;
using Services;

namespace UI
{
    public partial class F_User : Form
    {
        private readonly UserService userService;
        private readonly Dictionary<int, string> dic_permit = new Dictionary<int, string>()
        {
            {0, "Reader"},
            {1, "Admin"}
        };
        // ✅ Constructor mặc định – tự tạo DbContext
        public F_User() : this(new LibraryContext()) { }

        // ✅ Constructor chính – truyền LibraryContext để dùng lại
        public F_User(LibraryContext dbContext)
        {
            InitializeComponent();
            userService = new UserService(dbContext);
        }
       

        private void F_User_Load(object sender, EventArgs e)
        {
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv.MultiSelect = false;
            gv.ReadOnly = true;
            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;

            cb_permit.DataSource = new BindingSource(dic_permit.ToList(), null);
            cb_permit.DisplayMember = "Value";
            cb_permit.ValueMember = "Key";

            btnDelete.Visible = false;
            btnUpdate.Visible = false;

            LoadData();
        }

        private void LoadData()
        {
            gv.DataSource = null;
            gv.DataSource = userService.GetAll(); // ✅ Lấy dữ liệu từ DB

            gv.Columns["UserId"].HeaderText = "Mã người dùng";
            gv.Columns["FullName"].HeaderText = "Họ và tên";
            gv.Columns["UserName"].HeaderText = "Tên đăng nhập";
            gv.Columns["Email"].HeaderText = "Email";
            gv.Columns["Phone"].HeaderText = "Số điện thoại";
            gv.Columns["IsActive"].HeaderText = "Kích hoạt";
            gv.Columns["Birthday"].HeaderText = "Ngày sinh";
            gv.Columns["Role"].HeaderText = "Vai trò";
            gv.Columns["Password"].HeaderText = "Mật khẩu";
            gv.Columns["Address"].HeaderText = "Địa chỉ";
            gv.Columns["CreatedAt"].HeaderText = "Ngày tạo";
            // Ẩn cột mật khẩu
            gv.Columns["Password"].Visible = false;
            // giãn toàn bộ chiều ngang
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //không cho người dùng thêm dòng trống
            gv.AllowUserToAddRows = false;

            // bo góc hiển thị đẹp hơn
            gv.RowHeadersVisible = false;
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            if (gv.CurrentRow == null) return;

            if (gv.CurrentRow.DataBoundItem is UserDTO user)
            {
                txtId.Text = user.UserId.ToString();
                txt_fullname.Text = user.FullName;
                txt_username.Text = user.UserName;
                txt_email.Text = user.Email;
                txt_phone.Text = user.Phone;
                ck_active.Checked = user.IsActive;
                dt_Birthday.Value = user.Birthday ?? DateTime.Now;
                cb_permit.SelectedValue = dic_permit.FirstOrDefault(x => x.Value == user.Role).Key;
                txt_pass.Text=user.Password;
                txt_address.Text = user.Address;
            }

            txtId.Enabled = false;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new UserDTO
                {
                    FullName = txt_fullname.Text.Trim(),
                    UserName = txt_username.Text.Trim(),
                    Email = txt_email.Text.Trim(),
                    Phone = txt_phone.Text.Trim(),
                    Address = txt_address.Text.Trim(),
                    Password = txt_pass.Text.Trim(),
                    Role = dic_permit[(int)cb_permit.SelectedValue],
                    Birthday = dt_Birthday.Value,
                    IsActive = ck_active.Checked
                };

                var result = userService.Add(user);
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
                MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv.CurrentRow == null) return;

                var user = new UserDTO
                {
                    UserId = int.Parse(txtId.Text),
                    FullName = txt_fullname.Text.Trim(),
                    UserName = txt_username.Text.Trim(),
                    Email = txt_email.Text.Trim(),
                    Phone = txt_phone.Text.Trim(),
                    IsActive = ck_active.Checked,
                    Password = txt_pass.Text.Trim(),
                    Role = dic_permit[(int)cb_permit.SelectedValue],
                    Birthday = dt_Birthday.Value,
                    Address = txt_address.Text.Trim()
                };

                var result = userService.Update(user);
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
                MessageBox.Show("Lỗi khi cập nhật người dùng: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv.CurrentRow == null) return;
                int id = (int)gv.CurrentRow.Cells["UserId"].Value;

                if (MessageBox.Show("Bạn có chắc muốn xóa người dùng này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var result = userService.Delete(id);
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa người dùng: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var users = userService.GetAll();

                string json = JsonSerializer.Serialize(users, new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                });

                rt_json.Text = json;
                MessageBox.Show("Xuất dữ liệu JSON thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất JSON: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => ClearForm();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        private void ClearForm()
        {
            txtId.Enabled = true;
            txtId.Text = string.Empty;
            txt_fullname.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_address.Text = string.Empty;

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }

        private void F_User_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
