namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplicationHeader : _BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApplicationHeader()
        {
            Adjustments = new HashSet<Adjustment>();
            ApplicationContractors = new HashSet<ApplicationContractor>();
            ApplicationGISLines = new HashSet<ApplicationGISLine>();
            ApplicationGISPoints = new HashSet<ApplicationGISPoint>();
            ApplicationGISPolygons = new HashSet<ApplicationGISPolygon>();
            ApplicationInvoices = new HashSet<ApplicationInvoice>();
            ApplicationLocationInfoes = new HashSet<ApplicationLocationInfo>();
            Cashes = new HashSet<Cash>();
            Deposits = new HashSet<Deposit>();
            Liabilities = new HashSet<Liability>();
            Receivables = new HashSet<Receivable>();
            Revenues = new HashSet<Revenue>();
        }

        public long Id { get; set; }

        public long? ApplicantId { get; set; }

        public long ApplicationTypeId { get; set; }

        public long DepartmentId { get; set; }

        public int ExistingDwellingUnits { get; set; }

        [Required]
        [StringLength(500)]
        public string ProjectDescription { get; set; }

        public long? PowerCompanyId { get; set; }

        public decimal ElectricalServiceAmps { get; set; }

        [Required]
        public string ElectricMeterNumber { get; set; }

        [Required]
        public string ElectricAccountNumber { get; set; }

        public long ProjectTypeId { get; set; }

        public decimal ParcelAcres { get; set; }

        public decimal TotalSquareFootage { get; set; }

        public decimal HeatedSquareFootage { get; set; }

        public decimal ConstructionCostPerSQFt { get; set; }

        public decimal TotalConstructionCost { get; set; }

        public decimal TotalPlumbingCost { get; set; }

        public decimal TotalElectricalCost { get; set; }

        public decimal TotalMechanicalCost { get; set; }

        public int BuildingStories { get; set; }

        public decimal BuildingHeight { get; set; }

        public decimal GroundClearanceHeight { get; set; }

        public decimal SitePlanSetbackFront { get; set; }

        public decimal SitePlanSetbackLeftSide { get; set; }

        public decimal SitePlanSetbackRightBack { get; set; }

        public decimal SitePlanSetbackRightRear { get; set; }

        public decimal SetbackFront { get; set; }

        public decimal SetbackLeftSide { get; set; }

        public decimal SetbackRightBack { get; set; }

        public decimal SetbackRightRear { get; set; }

        [Required]
        [StringLength(55)]
        public string SepticPermitNumber { get; set; }

        [Required]
        [StringLength(55)]
        public string DevelopmentPermitNumber { get; set; }

        [Required]
        [StringLength(55)]
        public string SpecialTemporaryUsePermitNumber { get; set; }

        public long? BuildingCodeEditionId { get; set; }

        public long? ElectricalCodeEditionId { get; set; }

        [Required]
        [StringLength(255)]
        public string SubmittedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SubmittedOn { get; set; }



        public long? PermitNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PermittedOn { get; set; }

        [StringLength(450)]
        public string PermittedByUserName { get; set; }

        public long? BuildingCodeOccupancyTypeId { get; set; }

        public long? BuildingCodeElementId { get; set; }

        public long? BuildingCodeConstructionTypeId { get; set; }

        public Guid? ConfirmationCode { get; set; }

        public Guid? UniqueID { get; set; }

        public decimal AmountInvoiced { get; set; }

        public decimal AmountPaid { get; set; }

        public decimal AmountPendingInvoice { get; set; }

        public decimal AmountDue { get; set; }

        [Required]
        [StringLength(255)]
        public string ApplicantProjectName { get; set; }

        public AppUser AssignedTo { get; set; }

        public decimal BuildingPermitFee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjustment> Adjustments { get; set; }

        public virtual Applicant Applicant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationContractor> ApplicationContractors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationGISLine> ApplicationGISLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationGISPoint> ApplicationGISPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationGISPolygon> ApplicationGISPolygons { get; set; }

        public virtual ApplicationProjectType ApplicationProjectType { get; set; }

        public virtual ApplicationType ApplicationType { get; set; }

        public virtual AppUser PermittedBy { get; set; }

       

        public virtual BuildingCodeConstructionType BuildingCodeConstructionType { get; set; }

        public virtual BuildingCodeEdition BuildingCodeEdition { get; set; }

        public virtual BuildingCodeElement BuildingCodeElement { get; set; }

        public virtual BuildingCodeOccupancyType BuildingCodeOccupancyType { get; set; }

        public virtual Department Department { get; set; }



        public virtual ElectricalCodeEdition ElectricalCodeEdition { get; set; }

        public virtual PowerCompany PowerCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationInvoice> ApplicationInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationLocationInfo> ApplicationLocationInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cash> Cashes { get; set; }

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
