using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public string FCA { get; set; }
        public string NFA { get; set; }
        public string SFC { get; set; }
    }
}