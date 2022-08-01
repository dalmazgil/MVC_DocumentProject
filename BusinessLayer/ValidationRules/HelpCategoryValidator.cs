using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HelpCategoryValidator : AbstractValidator<HelpCategory>
    {
        public HelpCategoryValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Kategori adı boş olamaz");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Kategori açıklaması boş olamaz");
            RuleFor(x=>x.Image).NotEmpty().WithMessage("Resim url bilgisi boş olamaz");
            RuleFor(x=>x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
        }
    }
}
