namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InspectionSubType : _BaseEntity
    {
        public long Id { get; set; }

        public long InspectionTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public bool ShowOnWeb { get; set; }

        public bool IsDefault { get; set; }

        public bool IsFinal { get; set; }

        public bool CanReleasePower { get; set; }

        public bool IsNailingInspection { get; set; }

        public bool AllowIfSpecialFloodHazardArea { get; set; }

        public bool EmailApplicantOnCompletion { get; set; }

        public bool EmailContractorsOnCompletion { get; set; }


        public virtual InspectionType InspectionType { get; set; }
    }
}
