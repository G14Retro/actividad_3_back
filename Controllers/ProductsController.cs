using actividad_3_back.Context;
using actividad_3_back.Models;
using actividad_3_back.Models.DAO;
using actividad_3_back.Services.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;

namespace actividad_3_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Private Fields
        private readonly IProducts _product;
        #endregion

        #region Constructor
        public ProductsController(IProducts product)
        {
            _product = product;
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _product.GetAllProducts());
        }


        //[HttpGet]
        //public async Task<IActionResult> GetProductById(Guid idProduct)
        //{
        //    return Ok(await _product.GetProductById(idProduct));
        //}

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateProduct(ProductDTO product)
        {
            return Ok(await _product.CreateProduct(product));
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateProduct(ProductDTO product)
        {
            return Ok(await _product.UpdateProduct(product));
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteProduct(Guid Idproduct)
        {
            Ok(await _product.DeleteProduct(Idproduct));
            return NoContent();
        }

    }
}
