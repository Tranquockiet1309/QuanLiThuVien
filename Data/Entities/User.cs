using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Tên người dùng là bắt buộc")]
        [StringLength(150)]
        public string FullName { get; set; } = null!;
        [Required(ErrorMessage = "Tên người dùng là bắt buộc")]
        [StringLength(150)]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Email là bắt buộc")]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [StringLength(20)]
        public string? Phone { get; set; }

        [StringLength(255)]
        public string? Address { get; set; }

        [StringLength(50)]
        public string? Role { get; set; } // ví dụ: "Admin", "Reader"

        [Required, StringLength(255)]
        public string Password { get; set; } = string.Empty;   // lưu HASH

        public bool IsActive { get; set; } = true;
        public DateTime? Birthday { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        // Một người dùng có thể mượn nhiều sách
        public ICollection<Borrowbooks> Borrowbooks { get; set; } = new List<Borrowbooks>();
        // Một người có thể checkin nhiều lần
        public ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();
        // Một người có thể có nhiều điểm rèn luyện
        public ICollection<PointsLedger> PointsLedgers { get; set; } = new List<PointsLedger>();

    }
}
