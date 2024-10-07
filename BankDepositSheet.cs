namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BankDepositSheet : _BaseEntity
    {
        public long Id { get; set; }

        public long CashId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DepositDate { get; set; }

        public bool Cleared { get; set; }

     
        public virtual Cash Cash { get; set; }


    }
}
