using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text.Json.Serialization;

namespace Weaver.Permitting.DB
{
    public abstract class _BaseEntity: _PrimaryKey
    {
        public AppUser CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public AppUser DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
   
        public long? DocumentStorageId { get; set; }
        public int FiscalMonth { get; set; }
        public int FiscalYear { get; set; }
        public bool IsDeleted { get; set; }
        public AppUser LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public long MigrationID { get; set; }

   
        [CalculationProperty]
        [JsonIgnore]
        public int CurrentFiscalYear
        {
            get
            {
                return DateTime.Now.Month >= 10 ? DateTime.Now.Year + 1 : DateTime.Now.Month;

            }
        }
        [NotMapped]
        [CalculationProperty]
        [JsonIgnore]
        public int CurrentFiscalMonth
        {
            get
            {
                return DateTime.Now.Month >= 10 ? DateTime.Now.Month - 9 : DateTime.Now.Month + 3;

            }
        }

        public virtual DocumentStorage DocumentStorage { get; set; }
        [NotMapped]
        public DateTime FiscalYearStartDate { get { return new DateTime(CurrentFiscalYear > DateTime.Now.Year ? DateTime.Now.Year : CurrentFiscalYear, 10, 1); } }


        [StringLength(100)]
        public string MigrationMisc { get; set; }

        public void Update(AppUser user)
        {

            LastUpdatedBy = user;
            LastUpdatedOn = DateTime.Now;
        }
        public void Delete(AppUser user)
        {
            if (DeletedBy != null)
                return;
            IsDeleted = true;
            DeletedBy = user;
            DeletedOn = DateTime.Now;
        }

        public void Create(AppUser user)
        {
            if (CreatedBy != null)
                return;

            CreatedBy = user;
            CreatedOn = DateTime.Now;
        }
        public void PostDocument(Stream s, string FileName)
        {
            if (DocumentStorage == null)
                DocumentStorage = new DocumentStorage();

            var f = new DocumentStorageFile();
            f.FileSize = s.Length;
            f.FileName = FileName;
            f.FileExt = Path.GetExtension(f.FileName);
            f.CreatedOn = DateTime.Now;
            using (var ms = new MemoryStream())
            {
                s.CopyTo(ms);
                f.FileData = ms.ToArray();
            }


        }
    }
}