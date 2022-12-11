using FluentValidation;
using KatmanliMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Business.FluentValidation
{
    public class UrunValidator:AbstractValidator<urun>
    {
        public UrunValidator()
        {
            RuleFor(p=>p.UrunIsmi).NotEmpty().WithMessage("ürün ismi boş bırakılmaz");
            RuleFor(p => p.Fiyat).NotEmpty().WithMessage("ürün fiyatı boş bırakılamaz");
            RuleFor(p=>p.KategoriId).NotEmpty().WithMessage("kategori boş bırakılamaz");

            RuleFor(p => p.Fiyat).GreaterThan(0);
            RuleFor(p => p.Fiyat).LessThan(10000);
            RuleFor(p => p.Fiyat).GreaterThan(150).When(p => p.KategoriId == 2);

            RuleFor(p => p.UrunIsmi).Must(StartWithA);

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
