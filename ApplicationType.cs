namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplicationType : _BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApplicationType()
        {
            ApplicationHeaders = new HashSet<ApplicationHeader>();
            ApplicationTypeDocuments = new HashSet<ApplicationTypeDocument>();
            ApplicationTypeFees = new HashSet<ApplicationTypeFee>();
            ApplicationTypeFields = new HashSet<ApplicationTypeField>();
        }

        public long Id { get; set; }

        public long DepartmentId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsPublic { get; set; }

        [Required]
        public string Instructions { get; set; }

     

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationHeader> ApplicationHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationTypeDocument> ApplicationTypeDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationTypeFee> ApplicationTypeFees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationTypeField> ApplicationTypeFields { get; set; }

       
        public virtual Department Department { get; set; }


    }
}
