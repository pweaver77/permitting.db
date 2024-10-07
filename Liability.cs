namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Liability :_Accounting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Liability()
        {
            Receivables = new HashSet<Receivable>();
        }

  

        [StringLength(450)]
        public string LiabilityAccountAccountNumber { get; set; }

        public long CashId { get; set; }

      

        public long? FeeId { get; set; }



    


        public virtual Cash Cash { get; set; }



        public virtual Fee Fee { get; set; }

        public virtual LiabilityAccount LiabilityAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receivable> Receivables { get; set; }
    }
}
