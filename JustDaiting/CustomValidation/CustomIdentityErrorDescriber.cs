﻿using Microsoft.AspNetCore.Identity;

namespace JustDaiting.CustomValidation
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "InvalidUserName",
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DublicateEmail",
                Description = $"Bu {email} geçersizdir!"
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswoedTooShort",
                Description = $"Şifreniz en az {length} karakterli olmalıdır !"
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "DuplicateUserName",
                Description = $"Bu Kullanıcı Adı:({userName}) zaten kullanılmaktadır !"
            };
        }
    }
}