using System;
using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class Breach
    {
        [Key]
        public int Id { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public DateTime Date { get; set; }
        
        [MaxLength(200)]
        public string Subject { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [MaxLength(1000)]
        public string Comments { get; set; }

        public bool Deleted { get; set; }
    }
}