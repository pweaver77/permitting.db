namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExpenseAccount : _Accounting
    {
   


        [StringLength(450)]
        public string FinanceAccountMasterAccountNumber { get; set; }



        public decimal TotalDebits { get; set; }

        public decimal TotalCredits { get; set; }

        public decimal TotalBalance { get; set; }

        public decimal CurrentFYDebits { get; set; }

        public decimal CurrentFYCredits { get; set; }

        public virtual FinanceAccountMaster FinanceAccountMaster { get; set; }
    }
}
