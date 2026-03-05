using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CateId { get; set; }
        [StringLength(100)]
        public string CateName { get; set; } = null!;
        [Column(TypeName = "nvarchar(200)")]
        public string? Img { get; set; }
        [StringLength(400)]
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        //tham chieu toi Book
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
