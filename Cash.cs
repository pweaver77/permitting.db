namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cash")]
    public partial class Cash : _Accounting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cash()
        {
            BankDepositSheets = new HashSet<BankDepositSheet>();
            Deposits = new HashSet<Deposit>();
            Liabilities = new HashSet<Liability>();
            Receivables = new HashSet<Receivable>();
        }

     

        [StringLength(450)]
        public string CashAccountAccountNumber { get; set; }

        public long? PaymentTypeId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PaymentDate { get; set; }

        [Required]
        [StringLength(255)]
        public string ReferenceNumber { get; set; }


      

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankDepositSheet> BankDepositSheets { get; set; }

        public virtual CashAccount CashAccount { get; set; }

  


        public virtual PaymentType PaymentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deposit> Deposits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liability> Liabilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receivable> Receivables { get; set; }
    }
}
