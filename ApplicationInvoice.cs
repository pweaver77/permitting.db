namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplicationInvoice")]
    public partial class ApplicationInvoice : _BaseEntity
    {
        public long Id { get; set; }

        public long ApplicationId { get; set; }

        public long InvoiceId { get; set; }

      

        public virtual ApplicationHeader ApplicationHeader { get; set; }


        public virtual Invoice Invoice { get; set; }
    }
}
