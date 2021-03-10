using System;

namespace Appraiser.Data.Models
{
    public class Appraisal
    {
        public int Id { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public DateTimeOffset PeriodStart { get; set; }
        public DateTimeOffset PeriodEnd { get; set; }

        public bool Complete { get; set; }
        public bool Deleted { get; set; }
    }
}