using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün ismi boş geçirilemez.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçirilemez.");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok miktarı boş geçirilemez.");
        }
    }
}
