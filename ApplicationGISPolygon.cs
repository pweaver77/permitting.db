namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplicationGISPolygon")]
    public partial class ApplicationGISPolygon : _BaseEntity
    {
        public long Id { get; set; }

        public long CustomerApplicationId { get; set; }

        [Required]
        public DbGeography Shape { get; set; }

      

        public virtual ApplicationHeader ApplicationHeader { get; set; }

    }
}
