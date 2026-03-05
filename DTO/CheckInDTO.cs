using System;

namespace DTO
{
    public class CheckInDTO
    {
        public int CheckInId { get; set; }
        public int UserId { get; set; }

        // Họ tên người dùng (dùng khi hiển thị)
        public string? FullName { get; set; }

        public DateTime CheckInTime { get; set; }
        public string? Note { get; set; }

        // Hiển thị thêm thông tin tạo ra (nếu cần)
        public string? UserName { get; set; }
    }
}
