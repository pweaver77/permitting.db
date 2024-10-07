namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RevenueAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RevenueAccount()
        {
            Fees = new HashSet<Fee>();
            Revenues = new HashSet<Revenue>();
        }


        [Key]
        [StringLength(450)]
        public string AccountNumber { get; set; }

        [StringLength(450)]
        public string FinanceAccountMasterAccountNumber { get; set; }


        [StringLength(450)]
        public string Description { get; set; }

        [StringLength(450)]
        public string Comments { get; set; }

        public decimal TotalDebits { get; set; }

        public decimal TotalCredits { get; set; }

        public decimal TotalBalance { get; set; }

        public decimal CurrentFYDebits { get; set; }

        public decimal CurrentFYCredits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fee> Fees { get; set; }

        public virtual FinanceAccountMaster FinanceAccountMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Revenue> Revenues { get; set; }
    }
}
