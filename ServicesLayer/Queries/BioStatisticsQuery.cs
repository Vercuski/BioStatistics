using Domain;
using HotChocolate.Subscriptions;
using Repository.Interfaces;

namespace ServicesLayer.Queries
{

    public class BioStatisticsQuery
    {
        public async Task<BioStatistics> GetBioStatisticsById([Service] IBioStatisticsRepository bioStatisticsRepository,
            int statsId)
        {
            BioStatistics statistic = await bioStatisticsRepository.GetBioStatisticByIdAsync(statsId);
            return statistic;
        }

        public List<BioStatistics> GetAllBioStatistics([Service] IBioStatisticsRepository bioStatisticsRepository)
        {
            var statistics = bioStatisticsRepository.GetAllBioStatistics();
            return statistics;
        }
    }
}
