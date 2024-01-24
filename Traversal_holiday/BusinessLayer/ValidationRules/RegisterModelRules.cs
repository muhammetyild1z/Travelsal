using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class RegisterModelRules : AbstractValidator<AppUser>
    {
        public RegisterModelRules()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş geçilemez").EmailAddress().WithMessage("E-posta biçimini kontrol edin."); 

            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez.");

            RuleFor(x => x.PasswordHash).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
                

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numarası boş geçilemez")
                .Matches(@"[0-9]+").WithMessage("Telefon numarası sadece rakam içermelidir.")                
                .Length(10).WithMessage("Telefon numaranızı 0 olmadan 10 hane olarak giriniz.");



        }
    }
}
