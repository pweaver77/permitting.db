namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplicationContractor : _BaseEntity
    {
        public long Id { get; set; }

        public long CustomerApplicationId { get; set; }

        public long ContractorId { get; set; }

        [Required]
        [StringLength(255)]
        public string ContractorType { get; set; }

        [Required]
        [StringLength(255)]
        public string CountyLicenseNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CountyLicenseExpiration { get; set; }

        [Required]
        [StringLength(255)]
        public string StateyLicenseNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StateLicenseExpiration { get; set; }

     

        public virtual ApplicationHeader ApplicationHeader { get; set; }



        public virtual Contractor Contractor { get; set; }

    }
}
