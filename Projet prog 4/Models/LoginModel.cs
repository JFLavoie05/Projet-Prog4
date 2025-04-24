using System.ComponentModel.DataAnnotations;

namespace Projet_prog_4.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public required string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public required string Password { get; set; }
    }
}
