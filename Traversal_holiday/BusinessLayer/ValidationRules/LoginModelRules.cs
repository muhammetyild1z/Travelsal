using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class LoginModelRules:AbstractValidator<AppUser>
    {
        public LoginModelRules()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez.");

            RuleFor(x => x.PasswordHash).NotEmpty().WithMessage("Şifre boş geçilemez");
        }
    }
}
