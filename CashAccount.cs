namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CashAccount 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CashAccount()
        {
            Cashes = new HashSet<Cash>();
        }


        [Key]
        [StringLength(450)]
        public string AccountNumber { get; set; }

        [StringLength(450)]
        public string FinanceAccountMasterAccountNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public decimal TotalDebits { get; set; }

        public decimal TotalCredits { get; set; }

        public decimal TotalBalance { get; set; }

        public decimal CurrentFYDebits { get; set; }

        public decimal CurrentFYCredits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cash> Cashes { get; set; }

        public virtual FinanceAccountMaster FinanceAccountMaster { get; set; }
    }
}
