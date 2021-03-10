using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class FitnessQuestion
    {
        [Key]
        public int Id { get; set; }

        public int SectionNumber { get; set; }
        [MaxLength(100)]
        public string Section { get; set; }
        [MaxLength(100)]
        public string Subsection { get; set; }
        [MaxLength(3000)]
        public string Question { get; set; }
    }
}