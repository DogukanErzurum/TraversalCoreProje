using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidation
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlığı Boş Geçmeyin");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Duyuru İçeriğini Boş Geçmeyin");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 Karakterlik Bir Başlık Yazınız");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen en az 20 Karakterlik Bir Duyuru İçeriği Yazınız");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 Karakterlik Bir Başlık Yazınız");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 Karakterlik Bir Duyuru İçeriği Yazınız");
        }
    }
}
