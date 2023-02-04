using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooK_Market.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }   
        public string Description { get; set; }
        public string Publisher { get; set; }
        public DateTime? PublishOn { get; set; }
        public float Price { get; set; }
        public string ImgUrl { get; set; }
       
        public virtual ICollection< BookAuthor> BookAuthor { get; set; }
       
        public virtual PriceOffers PriceOffers { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}
