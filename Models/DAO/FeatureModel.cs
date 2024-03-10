using System.ComponentModel.DataAnnotations;

namespace actividad_3_back.Models.DAO
{
    public class FeatureModel
    {
        [Key]
        public Guid IdFeatures { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;

        public virtual ICollection<ProductModel> Product { get; set; }
    }
}
