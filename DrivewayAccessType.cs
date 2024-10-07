namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DrivewayAccessType : _BaseEntity
    {
        public long Id { get; set; }

        [Required]
        public string Description { get; set; }

      
    }
}
