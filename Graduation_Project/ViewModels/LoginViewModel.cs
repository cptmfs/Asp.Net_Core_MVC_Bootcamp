using System.ComponentModel.DataAnnotations;

namespace Graduation_Project.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "User name :")]
        public string Username { get; set; }
		[Required(ErrorMessage = "Please enter a E-mail")]
		public string Email { get; set; }
        [Display(Name = "Password :")]
        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
