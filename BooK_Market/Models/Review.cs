using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooK_Market.Models
{
    public class Review
    {
        [Key]
        public int RevId { get; set; }
        [Required]
        public string RevName { get; set;}
        [MaxLength(5),MinLength(1)]
        public int NumStar { get; set; }
        public string Comment { get; set;}
        [ForeignKey("BookId")]
       public virtual Book Book { get; set;}
    }
}
