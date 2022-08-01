using System.ComponentModel.DataAnnotations;

namespace JustDaiting.ViewModels
{
    public class PasswordResetViewModel
    {

        [Display(Name = "Email adresiniz")]
        [Required(ErrorMessage = "Email alanı gereklidir.")]
        [EmailAddress]
        public string Email { get; set; }

    }
}