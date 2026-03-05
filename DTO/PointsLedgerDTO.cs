using System;

namespace DTO
{
    public class PointsLedgerDTO
    {
        public int LedgerId { get; set; }
        public int UserId { get; set; }

        // Họ tên người dùng (phục vụ hiển thị)
        public string? FullName { get; set; }

        // Số điểm (dương: cộng, âm: trừ)
        public int Points { get; set; }

        // Lý do cộng/trừ điểm
        public string? Reason { get; set; }

        // Nếu điểm này được tạo ra từ lần check-in cụ thể
        public int? CheckInId { get; set; }

        // Thời điểm tạo bản ghi
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Tùy chọn: để hiển thị kèm thời gian check-in nếu có
        public DateTime? CheckInTime { get; set; }
    }
}
