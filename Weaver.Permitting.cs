using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Weaver.Permitting.DB
{
    public partial class PermittingDB : DbContext
    {
        public PermittingDB()
            : base("name=PermittingDB")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Adjustment> Adjustments { get; set; }
        public virtual DbSet<AdjustmentType> AdjustmentTypes { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<ApplicationContractor> ApplicationContractors { get; set; }
        public virtual DbSet<ApplicationDocument> ApplicationDocuments { get; set; }
        public virtual DbSet<ApplicationGISLine> ApplicationGISLines { get; set; }
        public virtual DbSet<ApplicationGISPoint> ApplicationGISPoints { get; set; }
        public virtual DbSet<ApplicationGISPolygon> ApplicationGISPolygons { get; set; }
        public virtual DbSet<ApplicationHeader> ApplicationHeaders { get; set; }
        public virtual DbSet<ApplicationInvoice> ApplicationInvoices { get; set; }
        public virtual DbSet<ApplicationLocationInfo> ApplicationLocationInfoes { get; set; }
        public virtual DbSet<ApplicationProjectType> ApplicationProjectTypes { get; set; }
        public virtual DbSet<ApplicationTypeDocument> ApplicationTypeDocuments { get; set; }
        public virtual DbSet<ApplicationTypeFee> ApplicationTypeFees { get; set; }
        public virtual DbSet<ApplicationTypeField> ApplicationTypeFields { get; set; }
        public virtual DbSet<ApplicationType> ApplicationTypes { get; set; }
        public virtual DbSet<AppUserPassordHistory> AppUserPassordHistories { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<BankDepositSheet> BankDepositSheets { get; set; }
        public virtual DbSet<BuildingCodeConstructionType> BuildingCodeConstructionTypes { get; set; }
        public virtual DbSet<BuildingCodeEdition> BuildingCodeEditions { get; set; }
        public virtual DbSet<BuildingCodeElement> BuildingCodeElements { get; set; }
        public virtual DbSet<BuildingCodeOccupancyType> BuildingCodeOccupancyTypes { get; set; }
        public virtual DbSet<Cash> Cashes { get; set; }
        public virtual DbSet<CashAccount> CashAccounts { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<CreditType> CreditTypes { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<DocumentStorageFile> DocumentStorageFiles { get; set; }
        public virtual DbSet<DocumentStorage> DocumentStorages { get; set; }
        public virtual DbSet<DrivewayAccessType> DrivewayAccessTypes { get; set; }
        public virtual DbSet<ElectricalCodeEdition> ElectricalCodeEditions { get; set; }
        public virtual DbSet<ExpenseAccount> ExpenseAccounts { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<FinanceAccountMaster> FinanceAccountMasters { get; set; }
        public virtual DbSet<FinanceAccountType> FinanceAccountTypes { get; set; }
  
        public virtual DbSet<InspectionSubType> InspectionSubTypes { get; set; }
        public virtual DbSet<InspectionType> InspectionTypes { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Liability> Liabilities { get; set; }
        public virtual DbSet<LiabilityAccount> LiabilityAccounts { get; set; }
        public virtual DbSet<MasterDocument> MasterDocuments { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PowerCompany> PowerCompanies { get; set; }
        public virtual DbSet<Receivable> Receivables { get; set; }
        public virtual DbSet<RevenueAccount> RevenueAccounts { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adjustment>();

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.Adjustments)
                .WithOptional(e => e.ApplicationHeader)
                .HasForeignKey(e => e.ApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.ApplicationContractors)
                .WithRequired(e => e.ApplicationHeader)
                .HasForeignKey(e => e.CustomerApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.ApplicationGISLines)
                .WithRequired(e => e.ApplicationHeader)
                .HasForeignKey(e => e.CustomerApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.ApplicationGISPoints)
                .WithRequired(e => e.ApplicationHeader)
                .HasForeignKey(e => e.CustomerApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.ApplicationGISPolygons)
                .WithRequired(e => e.ApplicationHeader)
                .HasForeignKey(e => e.CustomerApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.ApplicationInvoices)
                .WithRequired(e => e.ApplicationHeader)
                .HasForeignKey(e => e.ApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.ApplicationLocationInfoes)
                .WithOptional(e => e.ApplicationHeader)
                .HasForeignKey(e => e.CustomerApplicationID);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.Cashes)
                .WithOptional(e => e.ApplicationHeader)
                .HasForeignKey(e => e.ApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.Deposits)
                .WithOptional(e => e.ApplicationHeader)
                .HasForeignKey(e => e.ApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.Liabilities)
                .WithOptional(e => e.ApplicationHeader)
                .HasForeignKey(e => e.ApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.Receivables)
                .WithOptional(e => e.ApplicationHeader)
                .HasForeignKey(e => e.ApplicationId);

            modelBuilder.Entity<ApplicationHeader>()
                .HasMany(e => e.Revenues)
                .WithOptional(e => e.ApplicationHeader)
                .HasForeignKey(e => e.ApplicationId);

            modelBuilder.Entity<ApplicationLocationInfo>()
                .Property(e => e.Latitude)
                .HasPrecision(13, 13);

            modelBuilder.Entity<ApplicationLocationInfo>()
                .Property(e => e.Longitude)
                .HasPrecision(13, 13);

            modelBuilder.Entity<ApplicationProjectType>()
                .HasMany(e => e.ApplicationHeaders)
                .WithRequired(e => e.ApplicationProjectType)
                .HasForeignKey(e => e.ProjectTypeId);

            modelBuilder.Entity<AppUser>();

            modelBuilder.Entity<Department>()
                .HasMany(e => e.ApplicationTypes)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinanceAccountType>()
                .HasMany(e => e.FinanceAccountMasters)
                .WithRequired(e => e.FinanceAccountType)
                .HasForeignKey(e => e.AccountType);
        }
    }
}
