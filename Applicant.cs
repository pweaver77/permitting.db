namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Applicant : _BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Applicant()
        {
            Adjustments = new HashSet<Adjustment>();
            ApplicationHeaders = new HashSet<ApplicationHeader>();
            Cashes = new HashSet<Cash>();
            Contractors = new HashSet<Contractor>();
            Deposits = new HashSet<Deposit>();
            Liabilities = new HashSet<Liability>();
            Receivables = new HashSet<Receivable>();
            Revenues = new HashSet<Revenue>();
        }


        [Required]
        [StringLength(75)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(75)]
        public string LastName { get; set; }

        [Required]
        [StringLength(1)]
        public string MiddleInitial { get; set; }

        [Required]
        [StringLength(75)]
        public string BusinessName { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(55)]
        public string State { get; set; }

        [Required]
        [StringLength(20)]
        public string Zip { get; set; }

        [Required]
        [StringLength(55)]
        public string Country { get; set; }

        [Required]
        [StringLength(25)]
        public string PrimaryPhone { get; set; }

        [Required]
        [StringLength(25)]
        public string PrimaryPhoneExtension { get; set; }

        [Required]
        [StringLength(25)]
        public string SecondaryPhone { get; set; }

        [Required]
        [StringLength(25)]
        public string SecondaryPhoneExtension { get; set; }

        [Required]
        [StringLength(25)]
        public string CellPhone { get; set; }

        [Required]
        [StringLength(25)]
        public string Fax { get; set; }

        [Required]
        [StringLength(255)]
        public string HomePage { get; set; }

        [Required]
        [StringLength(255)]
        public string PrimaryEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string SecondaryEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string PrimaryBusinessEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string SecondaryBusinessEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjustment> Adjustments { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationHeader> ApplicationHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cash> Cashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contractor> Contractors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deposit> Deposits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liability> Liabilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receivable> Receivables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Revenue> Revenues { get; set; }
    }
}
