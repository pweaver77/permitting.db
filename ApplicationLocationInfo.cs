namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplicationLocationInfo")]
    public partial class ApplicationLocationInfo : _BaseEntity
    {
        public long Id { get; set; }

        public long? CustomerApplicationID { get; set; }

        [Required]
        public string ParcelNo { get; set; }

        [Required]
        public string ParcelOwnerName { get; set; }

        [Required]
        public string ZonedFor { get; set; }

        [Required]
        public string FutureLandUse { get; set; }

        [Required]
        public string FloodZone { get; set; }

        [Required]
        public string MunicipalityName { get; set; }

        [Required]
        public string FullAddress { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        [Required]
        public string StreetName { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public DbGeography Shape { get; set; }

        public virtual ApplicationHeader ApplicationHeader { get; set; }
    }
}
