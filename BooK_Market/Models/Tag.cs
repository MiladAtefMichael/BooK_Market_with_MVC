using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooK_Market.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }
        [ForeignKey("BookId")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
