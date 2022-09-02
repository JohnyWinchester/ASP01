using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreGB.Domain;
using WebStoreGB.Domain.Entities;
using WebStoreGB.Interfaces.Services;
using WebStoreGB.Services.Data;

namespace WebStoreGB.Services.Services.InMemory
{
    public class InMemoryProductData : IProductData
    {
        public IEnumerable<Section> GetSections() => TestData.Sections;

        public IEnumerable<Brand> GetBrands() => TestData.Brands;

        public IEnumerable<Product> GetProducts(ProductFilter filter = null)
        {
            IEnumerable<Product> query = TestData.Products;

            //if (filter?.SectionId != null)
            //    query = query.Where(x => x.SectionId == filter.SectionId);

            if (filter?.SectionId is { } section_id)
                query = query.Where(x => x.SectionId == section_id);

            if (filter?.BrandId is { } brand_id)
                query = query.Where(x => x.BrandId == brand_id);

            return query;
        }

        public Product GetProductById(int Id) => TestData.Products.FirstOrDefault(x => x.Id == Id);

        public Section GetSectionById(int Id) => TestData.Sections.FirstOrDefault(x => x.Id == Id);

        public Brand GetBrandById(int Id) => TestData.Brands.FirstOrDefault(x => x.Id == Id);

    }
}
