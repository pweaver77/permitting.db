namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplicationTypeFee")]
    public partial class ApplicationTypeFee : _BaseEntity
    {
        public long Id { get; set; }

        public long ApplicationTypeId { get; set; }

        public long? FeeId { get; set; }

    

        public virtual ApplicationType ApplicationType { get; set; }


        public virtual Fee Fee { get; set; }
    }
}
