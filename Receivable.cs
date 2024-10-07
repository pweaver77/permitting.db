namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receivable : _Accounting
    {
        public long Id { get; set; }



        public long? RevenueId { get; set; }

        public long? LiabilityId { get; set; }

        public long? CashId { get; set; }

    

        public long? FeeId { get; set; }

    


        public virtual AppUser AppUser { get; set; }

        public virtual AppUser AppUser1 { get; set; }

        public virtual AppUser AppUser2 { get; set; }

        public virtual Cash Cash { get; set; }


        public virtual Fee Fee { get; set; }

        public virtual Liability Liability { get; set; }

        public virtual Revenue Revenue { get; set; }
    }
}
