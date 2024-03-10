using System.ComponentModel.DataAnnotations;

namespace actividad_3_back.Models.DAO
{
    public class ProductModel
    {
        [Key]
        public Guid IdProducts { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Resumen { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public virtual ICollection<FeatureModel>? Features { get; set; }
    }
}
