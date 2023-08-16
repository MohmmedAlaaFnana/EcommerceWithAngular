using System.ComponentModel.DataAnnotations;

namespace EcommerceWithAngular.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]

        public string Email { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="The {0} must be at least {2} and at max {1}")]
        [Display(Name ="Password")]

        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]

        public string ConfirmPassword { get; set; }
    }
}
