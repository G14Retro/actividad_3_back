using actividad_3_back.Context;
using actividad_3_back.Models;
using actividad_3_back.Models.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace actividad_3_back.Services.Products
{
    public class Product : IProducts
    {


        private readonly AppDbContext _appDbContext;

       public Product(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<ProductModel>> GetAllProducts()
        {
            var products = await _appDbContext.Products.ToListAsync();
            return products;
        }

        public async Task<ProductModel> CreateProduct(ProductDTO product)
        {
            ProductModel productModel = new ProductModel()
            {
                Brand = product.Brand,
                Price = product.Price,
                Resumen = product.Resumen,
            };
            await _appDbContext.Products.AddAsync(productModel);
            await _appDbContext.SaveChangesAsync();
            return new ProductModel();
        }

        public async Task<ProductModel> DeleteProduct(Guid idProduct)
        {
            var productDelete = _appDbContext.Products.FindAsync(idProduct).Result;
            _appDbContext.Products.Remove(productDelete);
            await _appDbContext.SaveChangesAsync();
            return productDelete;
        }


        public async Task<ProductModel> GetProductById(Guid idProduct)
        {
            return _appDbContext.Products.FindAsync(idProduct).Result;
        }

        public async Task<ProductModel> UpdateProduct(ProductDTO product)
        {
            ProductModel productUpdate = new ProductModel() {
                IdProducts = (Guid)product.IdProducts,
                Brand = product.Brand,
                Price = product.Price,
                Resumen = product.Resumen,
            };
            _appDbContext.Update(productUpdate);
            await _appDbContext.SaveChangesAsync();
            return productUpdate;
        }
    }
}
