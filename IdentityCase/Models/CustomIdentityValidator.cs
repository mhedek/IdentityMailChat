using Microsoft.AspNetCore.Identity;

namespace IdentityCase.Models
{
    //Hata Mesajlarını türkçeleştirecez özelleştirecez
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresUpper() // Büyük harf hatası
        {
            return new IdentityError()
            {
                //Hatanın kodu
                Code = "PasswordRequiresUpper",
                Description = "Lütfen en az 1 tane büyük harf girişi yapınız!"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Lütfen en az 1 tane küçük harf girişi yapınız"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az 1 tane rakam girişi yapınız"
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            //lenght başlangiçta kaç karakter alacabileceğimizi belirtir. Program.cs tarafında değiştirilebilir
            //Default değeri 6
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Lütfen en az " + length + " karakter girişi yapınız"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Lütfen en az 1 tane özel karakter girişi yapınız"
            };
        }
    }
}
