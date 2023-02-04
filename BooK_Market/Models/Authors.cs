using System.ComponentModel.DataAnnotations;

namespace BooK_Market.Models
{
    public class Authors
    {
        [Key]
        public int AutId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
