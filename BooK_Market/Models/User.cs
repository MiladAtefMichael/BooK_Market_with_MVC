using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooK_Market.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        [Required]
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set;}
    }
}
