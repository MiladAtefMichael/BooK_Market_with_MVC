using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooK_Market.Models
{
    public class BookAuthor
    {
     
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
        public int AuthId { get; set; }
        [ForeignKey("AuthId")]
        public virtual Authors Author { get; set; }
        public int Order { get; set; }
       
   
    }
}
