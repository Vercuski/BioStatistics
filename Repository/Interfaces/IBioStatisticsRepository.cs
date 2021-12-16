using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IBioStatisticsRepository
    {
        Task<BioStatistics> AddNewBioStatisticAsync(BioStatistics newBioStatistic);
        Task<BioStatistics> UpdateBioStatisticAsync(BioStatistics updatedBioStatistic);
        Task<BioStatistics?> GetBioStatisticByIdAsync(int StatsId);
        List<BioStatistics> GetAllBioStatistics();
    }
}
