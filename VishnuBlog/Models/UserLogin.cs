using System.ComponentModel.DataAnnotations;

namespace VishnuBlog.Models
{
    public class UserLogin
    {
        [Key]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
