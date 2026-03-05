using System;

namespace DTO
{
    public class PublisherDTO
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? Logo { get; set; }

        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
