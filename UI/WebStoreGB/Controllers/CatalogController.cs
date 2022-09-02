using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebStoreGB.Domain;
using WebStoreGB.Domain.ViewModels;
using WebStoreGB.Interfaces.Services;
using WebStoreGB.Services.Mapping;

namespace WebStoreGB.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductData _ProductData;
        public CatalogController(IProductData productData)
        {
            _ProductData = productData;
        }
        public IActionResult Index(int? BrandId,int? SectionId)
        {
            var filter = new ProductFilter
            {
                BrandId = BrandId,
                SectionId = SectionId,
            };

            var products = _ProductData.GetProducts(filter);
            var view_model = new CatalogViewModel
            {
                BrandId = BrandId,
                SectionId = SectionId,
                Products = products.OrderBy(x => x.Order).ToView()
            };

            return View(view_model);
        }
        public IActionResult Details(int Id)
        {
            var product = _ProductData.GetProductById(Id);

            if (product is null) return NotFound();

            return View(product.ToView());
        }
    }
}
