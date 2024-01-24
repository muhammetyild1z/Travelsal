using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public  class AdminPanelDestinationRules:AbstractValidator<Destination>
    {
        public AdminPanelDestinationRules()
        {
            RuleFor(x => x.destinationCapacity).NotEmpty().WithMessage("Kapasite Alanı Boş Geçilemez.");

            RuleFor(x => x.CoverImage).NotEmpty().WithMessage("Banner resmi boş geçilemez.");

            RuleFor(x => x.destinationCity).NotEmpty().WithMessage("Tur şehri boş geçilemez.");

            RuleFor(x => x.destinationDate).NotEmpty().WithMessage("Tur tarihi boş geçilemez.");

            RuleFor(x => x.destinationDayNight).NotEmpty().WithMessage("Tur süresi boş geçilemez.");

            RuleFor(x => x.destinationDescription).NotEmpty().WithMessage("Tur açıklaması boş geçilmez");
            RuleFor(x => x.destinationDetails1).NotEmpty().WithMessage("Tur detay boş geçilmez");
            RuleFor(x => x.destinationDetails2).NotEmpty().WithMessage("Tur uyarı boş geçilmez");
            RuleFor(x => x.destinationPrice).NotEmpty().WithMessage("Tur fiyatı boş geçilmez");
            RuleFor(x => x.destinationImage).NotEmpty().WithMessage("Tur resmi boş geçilmez");
            RuleFor(x => x.destinationImage2).NotEmpty().WithMessage("Tur resmi boş geçilmez");

                       
        }
    }
}
