using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class FitnessAnswer
    {
        [Key]
        public int Id { get; set; }

        public int FitnessId { get; set; }
        public Fitness Fitness { get; set; }

        public int FitnessQuestionId { get; set; }
        public FitnessQuestion FitnessQuestion { get; set; }

        public bool? Answer { get; set; }
        [MaxLength(500)]
        public string Notes { get; set; }
    }
}