using Domain;
using Repository.Contexts;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Objects
{
    public class BioStatisticsRepository : IBioStatisticsRepository
    {
        private BioStatisticsDbContext _dbContext;

        public BioStatisticsRepository(BioStatisticsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BioStatistics> AddNewBioStatisticAsync(BioStatistics newBioStatistic)
        {
            _dbContext.BioStatistics.Add(newBioStatistic);
            _dbContext.SaveChanges();
            return newBioStatistic;
        }

        public async Task<BioStatistics> UpdateBioStatisticAsync(BioStatistics updatedBioStatistic)
        {
            _dbContext.BioStatistics.Update(updatedBioStatistic);
            _dbContext.SaveChanges();
            return updatedBioStatistic;
        }

        public List<BioStatistics> GetAllBioStatistics()
        {
            return _dbContext.BioStatistics.ToList();
        }

        public async Task<BioStatistics?> GetBioStatisticByIdAsync(int StatsId) => _dbContext.BioStatistics.SingleOrDefault(x => x.StatsId == StatsId);
    }
}
