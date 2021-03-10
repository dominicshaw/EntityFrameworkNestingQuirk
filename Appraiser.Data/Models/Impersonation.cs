using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class Impersonation
    {
        [Key]
        public int Id { get; set; }

        public int ImpersonatorId { get; set; }
        public Staff Impersonator { get; set; }

        public int ImpersonatesId { get; set; }
        public Staff Impersonates { get; set; }
    }
}