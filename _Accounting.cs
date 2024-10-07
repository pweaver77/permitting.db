using System;
using System.ComponentModel.DataAnnotations;

namespace Weaver.Permitting.DB
{
    
    public abstract class _Accounting : _BaseEntity
    {
        [Key]
        [StringLength(450)]
        public string AccountNumber { get; set; }
       public  Adjustment Adjustment { get; set; }
        public long? AdjustmentId { get; set; }
        public Applicant Applicant { get; set; }
        public long? ApplicantId { get; set; }
        public ApplicationHeader ApplicationHeader { get; set; }
        public long? ApplicationId { get; set; }
        public string Comments { get; set; }
        public Contractor Contractor { get; set; }
        public long? ContractorId { get; set; }
        public decimal Credit { get; set; }
        public DateTime? DatePosted { get; set; }
        public int Day { get; set; }
        public decimal Debit { get; set; }
        public string Description { get; set; }

        public int Month { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}