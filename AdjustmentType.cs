namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdjustmentType")]
    public partial class AdjustmentType : _BaseEntity
    {
        public long Id { get; set; }

        [Required]
        public string AdjustmentName { get; set; }

        [Required]
        [StringLength(1)]
        public string DebitOrCredit { get; set; }

    }
}
