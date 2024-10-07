namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinanceAccountMaster")]
    public partial class FinanceAccountMaster : _Accounting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinanceAccountMaster()
        {
            CashAccounts = new HashSet<CashAccount>();
            ExpenseAccounts = new HashSet<ExpenseAccount>();
            LiabilityAccounts = new HashSet<LiabilityAccount>();
            RevenueAccounts = new HashSet<RevenueAccount>();
        }



        public FinanceAccountType AccountType { get; set; }


        public decimal TotalDebits { get; set; }

        public decimal TotalCredits { get; set; }

        public decimal TotalBalance { get; set; }

        public decimal CurrentFYDebits { get; set; }

        public decimal CurrentFYCredits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashAccount> CashAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpenseAccount> ExpenseAccounts { get; set; }

        public virtual FinanceAccountType FinanceAccountType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LiabilityAccount> LiabilityAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RevenueAccount> RevenueAccounts { get; set; }
    }
}
