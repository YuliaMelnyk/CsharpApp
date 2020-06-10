using System.ComponentModel.DataAnnotations;

namespace csharp.Models
{
    public class RegisterViewModel
    {
        [Display(Name="Email")]
        public string Email { get; set; }

        [Display(Name="FirstName")]
        public string FirstName { get; set; }

        [Display(Name="LastName")]
        public string LastName { get; set; }

        [Display(Name="Password")]
        public string Password { get; set; }

        [Display(Name="ConfirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}