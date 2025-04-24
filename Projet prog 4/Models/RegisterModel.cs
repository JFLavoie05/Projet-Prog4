using System.ComponentModel.DataAnnotations;

namespace Projet_prog_4.Models
{
    public class RegisterModel
    {
        //Annotation modifier
        [Required(ErrorMessage = "User Name is required"), MinLength(3)]
        public required string Username { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public required string Password { get; set; }
    }
}
