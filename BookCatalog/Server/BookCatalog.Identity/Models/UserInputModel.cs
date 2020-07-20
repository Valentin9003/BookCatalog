using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Identity.Models
{
    using static Data.DataConstants.Identity;

    public class UserInputModel
    {
        [EmailAddress]
        [Required]
        [MinLength(MinEmailLength)]
        [MaxLength(MaxEmailLength)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
