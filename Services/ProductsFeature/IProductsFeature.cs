using actividad_3_back.Models.DAO;
using actividad_3_back.Models.DTO;

namespace actividad_3_back.Services.ProductsFeature
{
    public interface IProductsFeature
    {
        Task<ProductsFeatureModel> CreateProductsFeature(ProductsFeatureDTO features);
    }
}
