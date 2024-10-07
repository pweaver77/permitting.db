namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Address : _BaseEntity
    {
        public long Id { get; set; }

        [Required]
        [StringLength(15)]
        public string HouseNumber { get; set; }

        [Required]
        [StringLength(155)]
        public string StreetName { get; set; }

        [Required]
        [StringLength(155)]
        public string City { get; set; }

        [Required]
        [StringLength(155)]
        public string Region { get; set; }

        [Required]
        [StringLength(155)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(155)]
        public string Country { get; set; }

        [Required]
        [StringLength(155)]
        public string FullAddress { get; set; }

    }
}
