using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooK_Market.Models
{
    public class PriceOffers
    {
        [Key]
        public int PriceOfersId { get; set; }
        public float NewPrice { get; set; }
        public string PromaotionText { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
