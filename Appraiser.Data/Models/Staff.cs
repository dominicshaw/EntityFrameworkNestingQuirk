using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Logon { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public int? ManagerId { get; set; }
        public Staff Manager { get; set; }

        public int? SecondaryManagerId { get; set; }
        public Staff SecondaryManager { get; set; }
    }
}
