using actividad_3_back.Models;
using actividad_3_back.Models.DTO;
using actividad_3_back.Services.Features;
using actividad_3_back.Services.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace actividad_3_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        #region Private Fields
        private readonly IFeature _feature;
        #endregion

        #region Constructor
        public FeatureController(IFeature feature)
        {
            _feature = feature;
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> GetAllFeatures()
        {
            return Ok(await _feature.GetAllFeatures());
        }

        //[HttpGet]
        //public async Task<IActionResult> GetProductById(Guid idProduct)
        //{
        //    return Ok(await _product.GetProductById(idProduct));
        //}

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateProduct(FeatureDTO feature)
        {
            return Ok(await _feature.CreateFeature(feature));
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateProduct(FeatureDTO feature)
        {
            return Ok(await _feature.UpdateFeature(feature));
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteProduct(Guid idFeature)
        {

            Ok(await _feature.DeleteFeature(idFeature));
            return NoContent();
        }

    }
}
