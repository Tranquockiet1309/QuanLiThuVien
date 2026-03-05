using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("PointsLedger")]
    public class PointsLedger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LedgerId { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        // số điểm (dương: cộng, âm: trừ)
        public int Points { get; set; }

        [StringLength(255)]
        public string? Reason { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // (tuỳ chọn) nếu muốn biết điểm này đến từ check-in nào
        public int? CheckInId { get; set; }
        [ForeignKey(nameof(CheckInId))]
        public CheckIn? CheckIn { get; set; }
    }
}
