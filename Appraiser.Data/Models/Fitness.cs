using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class Fitness
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string Role { get; set; }
        [MaxLength(100)]
        public string AssessmentType { get; set; }

        public int? AssessedId { get; set; }
        public Staff Assessed { get; set; }

        public int? AssessorId { get; set; }
        public Staff Assessor { get; set; }
        
        [MaxLength(100)]
        public string AssessorRole { get; set; }

        public DateTime Date { get; set; }
        public DateTime? NextAssessmentDate { get; set; }
        
        public int? HonestyAssessed { get; set; }
        public int? CompetenceAssessed { get; set; }
        public int? FinancesAssessed { get; set; }

        public bool? SupportingEvidence { get; set; }
        public bool? PassCriteria { get; set; }
        public bool? ImposedLimitations { get; set; }
        public bool? CertificateProvided { get; set; }

        public DateTime? ComplianceSignoffAt { get; set; }
        [MaxLength(100)]
        public string ComplianceSignoffBy { get; set; }
        [MaxLength(500)]
        public string ComplianceSignoffNotes { get; set; }

        public DateTime? HrSignoffAt { get; set; }
        [MaxLength(100)]
        public string HrSignoffBy { get; set; }
        [MaxLength(500)]
        public string HrSignoffNotes { get; set; }

        public DateTime? AssessedSignoffAt { get; set; }
        [MaxLength(100)]
        public string AssessedSignoffBy { get; set; }
        [MaxLength(500)]
        public string AssessedSignoffNotes { get; set; }

        public DateTime? AssessorSignoffAt { get; set; }
        [MaxLength(100)]
        public string AssessorSignoffBy { get; set; }
        [MaxLength(500)]
        public string AssessorSignoffNotes { get; set; }
        
        public List<FitnessAnswer> Answers { get; set; }
    }
}
