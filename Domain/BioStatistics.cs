using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BioStatistics
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StatsId { get; set; }

        [Required]
        public DateTime StatsDate { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public byte SystolicBP { get; set; }

        [Required]
        public byte DiastolicBP { get; set; }

        [Required]
        public byte BloodSugar { get; set; }

        [Required]
        public byte Pulse { get; set; }
        
        [Required]
        public string Notes { get; set; }
    }
}