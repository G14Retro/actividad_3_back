using actividad_3_back.Context;
using actividad_3_back.Models.DAO;
using actividad_3_back.Models.DTO;

namespace actividad_3_back.Services.ProductsFeature
{
    public class ProductsFeature : IProductsFeature
    {
        private readonly AppDbContext _appDbContext;

        public ProductsFeature(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ProductsFeatureModel> CreateProductsFeature(ProductsFeatureDTO features)
        {
            foreach (var feature in features.Products.Features)
            {
                ProductsFeatureModel productsFeature = new ProductsFeatureModel()
                {
                    IdProducts = features.Products.IdProducts,
                    IdFeatures = feature.IdFeatures,
                };
                await _appDbContext.ProductsFeatures.AddAsync(productsFeature);
            }
            await _appDbContext.SaveChangesAsync();
            throw new NotImplementedException();
        }
    }
}
