using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Entities;
using DTO;

namespace Services
{
    public class UserService
    {
        private readonly LibraryContext dbContext;

        public UserService(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // ✅ Lấy danh sách tất cả người dùng
        public List<UserDTO> GetAll()
        {
            return dbContext.Users
                .OrderBy(u => u.FullName)
                .Select(u => new UserDTO
                {
                    UserId = u.UserId,
                    FullName = u.FullName,   // 👈 giữ nguyên tên thật
                    UserName = u.UserName,   // 👈 map tên đăng nhập
                    Email = u.Email,
                    Phone = u.Phone,
                    IsActive = u.IsActive,
                    Birthday = u.Birthday,
                    Password = u.Password,
                    Role = u.Role,
                    Address = u.Address,
                    CreatedAt = u.CreatedAt
                })
                .ToList();
        }

        // ✅ Lấy người dùng theo ID
        public UserDTO? GetById(int id)
        {
            return dbContext.Users
                .Where(u => u.UserId == id)
                .Select(u => new UserDTO
                {
                    UserId = u.UserId,
                    FullName = u.FullName,
                    UserName = u.UserName,
                    Email = u.Email,
                    Phone = u.Phone,
                    Address = u.Address,
                    CreatedAt = u.CreatedAt
                })
                .SingleOrDefault();
        }

        // ✅ Thêm người dùng mới
        public ServiceResult Add(UserDTO dto)
        {
            if (string.IsNullOrEmpty(dto.FullName))
                return new ServiceResult { Success = false, Message = "Tên đầy đủ không được để trống!" };

            if (string.IsNullOrEmpty(dto.UserName))
                return new ServiceResult { Success = false, Message = "Tên đăng nhập không được để trống!" };

            if (string.IsNullOrEmpty(dto.Email))
                return new ServiceResult { Success = false, Message = "Email là bắt buộc!" };

            // 🔍 Kiểm tra trùng username hoặc email
            bool usernameExists = dbContext.Users.Any(u => u.UserName.ToLower() == dto.UserName.ToLower());
            bool emailExists = dbContext.Users.Any(u => u.Email.ToLower() == dto.Email.ToLower());

            if (usernameExists)
                return new ServiceResult { Success = false, Message = "Tên đăng nhập đã tồn tại!" };
            if (emailExists)
                return new ServiceResult { Success = false, Message = "Email đã tồn tại!" };

            var entity = new User
            {
                FullName = dto.FullName,
                UserName = dto.UserName,
                Email = dto.Email,
                Phone = dto.Phone,
                Address = dto.Address,
                Password = dto.Password,
                IsActive = dto.IsActive,
                Birthday = dto.Birthday,
                Role = "Reader", // giá trị mặc định
                CreatedAt = DateTime.Now
            };

            try
            {
                dbContext.Users.Add(entity);
                dbContext.SaveChanges();
                return new ServiceResult { Success = true, Message = "Thêm người dùng thành công!" };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Lỗi khi thêm người dùng: {ex.Message}" };
            }
        }

        // ✅ Cập nhật người dùng
        public ServiceResult Update(UserDTO dto)
        {
            var entity = dbContext.Users.SingleOrDefault(u => u.UserId == dto.UserId);
            if (entity == null)
                return new ServiceResult { Success = false, Message = "Không tìm thấy người dùng cần cập nhật!" };

            if (string.IsNullOrEmpty(dto.FullName))
                return new ServiceResult { Success = false, Message = "Tên đầy đủ không được để trống!" };

            if (string.IsNullOrEmpty(dto.UserName))
                return new ServiceResult { Success = false, Message = "Tên đăng nhập không được để trống!" };

            // 🔍 Kiểm tra trùng username (với người khác)
            bool usernameExists = dbContext.Users
                .Any(u => u.UserId != dto.UserId && u.UserName.ToLower() == dto.UserName.ToLower());
            if (usernameExists)
                return new ServiceResult { Success = false, Message = "Tên đăng nhập đã tồn tại!" };

            entity.FullName = dto.FullName;
            entity.UserName = dto.UserName;
            entity.Email = dto.Email;
            entity.Phone = dto.Phone;
            entity.Password = dto.Password;
            entity.IsActive = dto.IsActive;
            entity.Address = dto.Address;
            entity.Role = dto.Role;
            entity.Birthday = dto.Birthday;
            entity.UpdatedAt = DateTime.Now;

            try
            {
                dbContext.SaveChanges();
                return new ServiceResult { Success = true, Message = "Cập nhật người dùng thành công!" };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Lỗi khi cập nhật người dùng: {ex.Message}" };
            }
        }

        // ✅ Xóa người dùng
        public ServiceResult Delete(int id, int? currentUserId = null)
        {
            var entity = dbContext.Users.SingleOrDefault(u => u.UserId == id);
            if (entity == null)
                return new ServiceResult { Success = false, Message = "Không tìm thấy người dùng cần xóa!" };

            // ❌ Chặn xoá tài khoản Admin
            if (string.Equals(entity.Role ?? "Reader", "Admin", StringComparison.OrdinalIgnoreCase))
                return new ServiceResult { Success = false, Message = "Không thể xóa tài khoản Admin!" };

            // ❌ Chặn xoá chính mình (người đang đăng nhập)
            if (currentUserId.HasValue && entity.UserId == currentUserId.Value)
                return new ServiceResult { Success = false, Message = "Không thể xóa tài khoản đang đăng nhập!" };

            // 🔍 Kiểm tra có phiếu mượn liên quan
            bool hasBorrowed = dbContext.Borrowbooks.Any(bb => bb.UserId == id);
            if (hasBorrowed)
                return new ServiceResult { Success = false, Message = "Không thể xóa người dùng đang mượn sách!" };

            try
            {
                dbContext.Users.Remove(entity);
                dbContext.SaveChanges();
                return new ServiceResult { Success = true, Message = "Xóa người dùng thành công!" };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Lỗi khi xóa người dùng: {ex.Message}" };
            }
        }
        public ServiceResult ChangePassword(int userId, string oldPassword, string newPassword)
        {
            var user = dbContext.Users.SingleOrDefault(u => u.UserId == userId);
            if (user == null)
                return new ServiceResult { Success = false, Message = "Không tìm thấy người dùng!" };

            // Kiểm tra mật khẩu cũ có đúng không
            if (user.Password != oldPassword)
                return new ServiceResult { Success = false, Message = "Mật khẩu cũ không chính xác!" };

            // Kiểm tra mật khẩu mới có hợp lệ không (ví dụ: ít nhất 6 ký tự)
            if (string.IsNullOrEmpty(newPassword) || newPassword.Length < 6)
                return new ServiceResult { Success = false, Message = "Mật khẩu mới phải có ít nhất 6 ký tự!" };

            // Cập nhật mật khẩu mới
            user.Password = newPassword;
            user.UpdatedAt = DateTime.Now;

            try
            {
                dbContext.SaveChanges();
                return new ServiceResult { Success = true, Message = "Đổi mật khẩu thành công!" };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Lỗi khi đổi mật khẩu: {ex.Message}" };
            }
        }

    }
}
