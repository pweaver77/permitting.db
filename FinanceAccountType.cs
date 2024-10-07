namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FinanceAccountType : _BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinanceAccountType()
        {
            FinanceAccountMasters = new HashSet<FinanceAccountMaster>();
        }

        [Key]
        [StringLength(5)]
        public string AccountType { get; set; }

        [Required]
        [StringLength(55)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinanceAccountMaster> FinanceAccountMasters { get; set; }
    }
}
