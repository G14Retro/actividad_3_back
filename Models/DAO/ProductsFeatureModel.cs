using Microsoft.EntityFrameworkCore;

namespace actividad_3_back.Models.DAO
{
    [Keyless]
    public class ProductsFeatureModel
    {
        public Guid IdProducts { get; set; }
        public Guid IdFeatures { get; set; }
    }
}
