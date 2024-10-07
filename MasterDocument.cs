namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MasterDocument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterDocument()
        {
            ApplicationDocuments = new HashSet<ApplicationDocument>();
            ApplicationTypeDocuments = new HashSet<ApplicationTypeDocument>();
        }

        public long Id { get; set; }

        public long DepartmentId { get; set; }

        [Required]
        [StringLength(255)]
        public string DocumentName { get; set; }

        [Required]
        public string Instructions { get; set; }

        public bool IsActive { get; set; }

        public int? DocumentNumber { get; set; }

        public long MigrationID { get; set; }

        [Required]
        [StringLength(100)]
        public string MigrationMisc { get; set; }

        [StringLength(450)]
        public string CreatedByUserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastUpdatedOn { get; set; }

        [StringLength(450)]
        public string LastUpdatedByUserName { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(450)]
        public string DeletedByUserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DeletedOn { get; set; }

        public int FiscalYear { get; set; }

        public int FiscalMonth { get; set; }

        public long? DocumentStorageId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationDocument> ApplicationDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationTypeDocument> ApplicationTypeDocuments { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual AppUser AppUser1 { get; set; }

        public virtual AppUser AppUser2 { get; set; }

        public virtual Department Department { get; set; }

        public virtual DocumentStorage DocumentStorage { get; set; }
    }
}
