namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppUserPassordHistory")]
    public partial class AppUserPassordHistory
    {
        public long Id { get; set; }

        public long MigrationID { get; set; }

        [Required]
        [StringLength(100)]
        public string MigrationMisc { get; set; }

        [StringLength(450)]
        public string CreatedByUserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastUpdatedOn { get; set; }

        [StringLength(450)]
        public string LastUpdatedByUserName { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(450)]
        public string DeletedByUserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DeletedOn { get; set; }

        public int FiscalYear { get; set; }

        public int FiscalMonth { get; set; }

        public long? DocumentStorageId { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual AppUser AppUser1 { get; set; }

        public virtual AppUser AppUser2 { get; set; }

        public virtual DocumentStorage DocumentStorage { get; set; }
    }
}
