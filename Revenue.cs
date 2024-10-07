namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Revenue : _Accounting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Revenue()
        {
            Receivables = new HashSet<Receivable>();
        }



        [StringLength(450)]
        public string RevenueAccountAccountNumber { get; set; }

        public long? FeeId { get; set; }

        public long? InvoiceId { get; set; }

        public decimal OriginalAmount { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal Amount { get; set; }


        public virtual AppUser AppUser { get; set; }

        public virtual AppUser AppUser1 { get; set; }

        public virtual AppUser AppUser2 { get; set; }


        public virtual Fee Fee { get; set; }

        public virtual Invoice Invoice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receivable> Receivables { get; set; }

        public virtual RevenueAccount RevenueAccount { get; set; }
    }
}
