using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Publishers")]
    public class Publisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherId { get; set; }

        [Required(ErrorMessage = "Tên nhà xuất bản là bắt buộc")]
        [StringLength(200)]
        public string PublisherName { get; set; } = null!;

        [StringLength(300)]
        public string? Address { get; set; }

        [StringLength(20)]
        public string? Phone { get; set; }
        [StringLength(255)]
        public string? Logo { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        // Một NXB có thể xuất bản nhiều sách
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
