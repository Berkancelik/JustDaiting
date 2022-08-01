﻿using System.ComponentModel.DataAnnotations;

namespace JustDaiting.ViewModels
{

    public class LoginViewModel
    {

        [Display(Name = "Email adresiniz")]
        [Required(ErrorMessage = "Email alanı gereklidir.")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Şifreniz")]
        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Şifreniz en az 4 karakterli olmalıdır.")]
        public string Password { get; set; }
    }
}