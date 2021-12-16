using Domain;
using Repository.Interfaces;

namespace ServicesLayer.Mutations
{
    public class BioStatisticsMutation
    {
        public async Task<BioStatistics> AddNewBioStatistic([Service] IBioStatisticsRepository bioStatisticsRepository, 
            BioStatistics newBioStatistic)
        {
            return await bioStatisticsRepository.AddNewBioStatisticAsync(newBioStatistic);
        }

        public async Task<BioStatistics> UpdateBioStatistic([Service] IBioStatisticsRepository bioStatisticsRepository,
            BioStatistics updatedBioStatistic)
        {
            return await bioStatisticsRepository.UpdateBioStatisticAsync(updatedBioStatistic);
        }
    }
}
