namespace actividad_3_back.Models.DTO
{
    public class FeatureDTO
    {
        public Guid? IdFeatures { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
