using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HelpDocumentValidator : AbstractValidator<HelpDocument>
    {
        public HelpDocumentValidator()
        {
            RuleFor(x => x.HelpCategoriesId).NotEmpty().WithMessage("Kategori ID boş olamaz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Doküman başlığı boş olamaz");
            RuleFor(x => x.Body).NotEmpty().WithMessage("Doküman açıklaması boş olamaz");
            RuleFor(x => x.Order).NotEmpty().WithMessage("Doküman sıralama bilgisi boş olamaz");
        }
    }
}
