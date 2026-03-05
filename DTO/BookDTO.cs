using System;

namespace DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string BookName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; } // Hiển thị tên thể loại nếu cần
        public int? PublisherId { get; set; }
        public string? PublisherName { get; set; } // Hiển thị tên NXB nếu cần
        public double Price { get; set; }
        public string? FileImg { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
