using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Borrowbooks")]
    public class Borrowbooks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        [DataType(DataType.Date)]
        public DateTime BorrowDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Status { get; set; }  // Ví dụ: "Đang mượn", "Đã trả"

        [StringLength(200)]
        public string? Note { get; set; }

        // Navigation Properties
        public User User { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}
