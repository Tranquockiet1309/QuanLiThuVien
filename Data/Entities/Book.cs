using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Tên sách là bắt buộc")]
        [StringLength(200)]
        public string BookName { get; set; } = null!;

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Publisher")]
        public int? PublisherId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public double Price { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? FileImg { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public Category Category { get; set; } = null!;
        public Publisher? Publisher { get; set; }
        public ICollection<Borrowbooks> Borrowbooks { get; set; } = new List<Borrowbooks>();
    }
}
