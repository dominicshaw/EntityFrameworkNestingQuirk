using System;
using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class Training
    {
        [Key]
        public int Id { get; set; }

        public int ReviewId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int TrainingType { get; set; }
        public DateTime? Date { get; set; }
    }
}