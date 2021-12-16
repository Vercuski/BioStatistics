using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contexts
{
    public class BioStatisticsDbContext : DbContext
    {
        public BioStatisticsDbContext(DbContextOptions<BioStatisticsDbContext> options) : base(options)
        {
        }
        //Create the DataSet for the Employee         
        public virtual DbSet<BioStatistics> BioStatistics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BioStatistics>(entity =>
            {
                entity.HasKey(e => e.StatsId);
                entity.Property(e => e.StatsDate).HasColumnType("date").IsRequired().HasColumnName("statsDate");
                entity.Property(e => e.Weight).HasColumnType("decimal(4,1)").IsRequired().HasColumnName("weight");
                entity.Property(e => e.SystolicBP).HasColumnType("tinyint").IsRequired().HasColumnName("systolicBP");
                entity.Property(e => e.DiastolicBP).HasColumnType("tinyint").IsRequired().HasColumnName("diastolicBP");
                entity.Property(e => e.BloodSugar).HasColumnType("tinyint").IsRequired().HasColumnName("bloodSugar");
                entity.Property(e => e.Pulse).HasColumnType("tinyint").IsRequired().HasColumnName("pulse");
                entity.Property(e => e.Notes).HasColumnType("varchar(max)").IsUnicode(false).IsRequired(false).HasColumnName("notes");
            });
        }
    }
}
