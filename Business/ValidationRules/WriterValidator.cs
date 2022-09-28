using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");           
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Minimum en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Minimum en fazla 50 karakterlik veri girişi yapın");
            RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifre en azı bir büyük harfden ibaret olmalıdır.");
            RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifre en azı bir kücük harfden ibaret olmalıdır.");
            RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifre en azı bir rakamdan ibaret olmalıdır.");


        }
    }
}
