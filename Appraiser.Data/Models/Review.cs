using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public string EmployeeNotes { get; set; }
        public string ManagerNotes { get; set; }
        public string Manager2Notes { get; set; }
        public List<Training> Training { get; set; }

        public bool Complete { get; set; }
    }
}