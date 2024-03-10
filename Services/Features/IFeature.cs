using actividad_3_back.Models.DAO;
using actividad_3_back.Models;
using actividad_3_back.Models.DTO;

namespace actividad_3_back.Services.Features
{
    public interface IFeature
    {
        Task<IEnumerable<FeatureModel>> GetAllFeatures();
        Task<FeatureModel> GetFeatureById(Guid idFeature);
        Task<FeatureModel> CreateFeature(FeatureDTO feature);
        Task<FeatureModel> UpdateFeature(FeatureDTO feature);
        Task<FeatureModel> DeleteFeature(Guid idFeature);
    }
}
