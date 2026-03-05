using System;

namespace DTO
{
    public class BorrowbooksDTO
    {
        public int BorrowId { get; set; }
        public int UserId { get; set; }
        public string? UserName { get; set; } // Hiển thị tên người mượn
        public int BookId { get; set; }
        public string? BookName { get; set; } // Hiển thị tên sách
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; } // true nếu đã trả sách
    }
}
