using actividad_3_back.Context;
using actividad_3_back.Models.DAO;
using actividad_3_back.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace actividad_3_back.Services.Features
{
    public class Feature : IFeature
    {

        private readonly AppDbContext _appDbContext;


        public Feature(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<FeatureModel> CreateFeature(FeatureDTO feature)
        {
            FeatureModel featureModel = new FeatureModel()
            {
                Name = feature.Name,
                Value = feature.Value,
            };
            await _appDbContext.AddAsync(featureModel);
            await _appDbContext.SaveChangesAsync();
            return featureModel;
        }

        public async Task<FeatureModel> DeleteFeature(Guid idFeature)
        {
            var featureDelete = await _appDbContext.Features.FindAsync(idFeature);
            _appDbContext.Features.Remove(featureDelete);
            await _appDbContext.SaveChangesAsync();
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FeatureModel>> GetAllFeatures()
        {
            return await _appDbContext.Features.ToListAsync();
        }

        public async Task<FeatureModel> GetFeatureById(Guid idFeature)
        {
            return await _appDbContext.Features.FindAsync(idFeature);
        }

        public async Task<FeatureModel> UpdateFeature(FeatureDTO feature)
        {
            FeatureModel featureModel = new FeatureModel()
            {
                IdFeatures = (Guid)feature.IdFeatures,
                Name = feature.Name,
                Value = feature.Value,
            };
            _appDbContext.Update(featureModel);
            await _appDbContext.SaveChangesAsync();
            return featureModel;
        }
    }
}
