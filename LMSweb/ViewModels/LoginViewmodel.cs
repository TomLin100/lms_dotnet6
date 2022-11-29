using System.ComponentModel.DataAnnotations;

namespace LMSweb.ViewModels
{
    public class LoginViewmodel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}