using FluentValidation;
using Nop.Web.Areas.Admin.Models.Catalog;
using Nop.Core.Domain.Catalog;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Admin.Validators.Catalog
{
    public partial class ProductValidator : BaseNopValidator<ProductModel>
    {
        public ProductValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Products.Fields.Name.Required"));
            RuleFor(x => x.BookAuthor).Length(0, 100).WithMessage(localizationService.GetResource("Admin.Catalog.Products.Fields.BookAuthor.Required")); ;

            SetDatabaseValidationRules<Product>(dbContext);
        }
    }
}