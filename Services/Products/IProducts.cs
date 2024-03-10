using actividad_3_back.Models;
using actividad_3_back.Models.DAO;

namespace actividad_3_back.Services.Products
{
    public interface IProducts
    {
        Task<IEnumerable<ProductModel>> GetAllProducts();
        Task<ProductModel> GetProductById(Guid idProduct);
        Task<ProductModel> CreateProduct(ProductDTO product);
        Task<ProductModel> UpdateProduct(ProductDTO product);
        Task<ProductModel> DeleteProduct(Guid idProduct);
    }
}
