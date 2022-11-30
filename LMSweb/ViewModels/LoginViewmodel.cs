using System.ComponentModel.DataAnnotations;

namespace LMSweb.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string ID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
