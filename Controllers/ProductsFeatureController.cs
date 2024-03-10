using actividad_3_back.Models.DTO;
using actividad_3_back.Services.Features;
using actividad_3_back.Services.ProductsFeature;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace actividad_3_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsFeatureController : ControllerBase
    {

        #region Private Fields
        private readonly IProductsFeature _productsFeature;
        #endregion

        #region Constructor
        public ProductsFeatureController (IProductsFeature productsFeature)
        {
            _productsFeature = productsFeature;
        }
        #endregion

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateProductFeature(ProductsFeatureDTO productFeatures)
        {
            return Ok(await _productsFeature.CreateProductsFeature(productFeatures));
        }
    }
}
