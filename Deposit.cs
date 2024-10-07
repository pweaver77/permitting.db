namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Deposit : _BaseEntity
    {
        public long Id { get; set; }

        [StringLength(450)]
        public string LiabilityAccountAccountNumber { get; set; }

        public long? CashId { get; set; }

    

        public long? ApplicantId { get; set; }

        public long? AdjustmentId { get; set; }

        public long? ApplicationId { get; set; }

        public long? ContractorId { get; set; }

        public long? FeeId { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DatePosted { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string Comments { get; set; }

        public decimal Credit { get; set; }

        public decimal Debit { get; set; }

        public virtual Adjustment Adjustment { get; set; }

        public virtual Applicant Applicant { get; set; }

        public virtual ApplicationHeader ApplicationHeader { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual AppUser AppUser1 { get; set; }

        public virtual AppUser AppUser2 { get; set; }

        public virtual Cash Cash { get; set; }

        public virtual Contractor Contractor { get; set; }



        public virtual Fee Fee { get; set; }

        public virtual LiabilityAccount LiabilityAccount { get; set; }
    }
}
