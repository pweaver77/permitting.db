namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BuildingCodeEdition : _BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildingCodeEdition()
        {
            ApplicationHeaders = new HashSet<ApplicationHeader>();
        }

        public long Id { get; set; }

        [Required]
        public string EditionName { get; set; }

        public bool IsActive { get; set; }

     

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationHeader> ApplicationHeaders { get; set; }

     
    }
}
