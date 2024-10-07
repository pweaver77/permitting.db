namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplicationTypeDocument : _BaseEntity
    {
        public long Id { get; set; }

        public long ApplicationTypeId { get; set; }

        public long MasterDocumentId { get; set; }

        public bool IsRequiredBeforeSubmittal { get; set; }

        public bool IsRequiredBeforeFinal { get; set; }

        public bool IsRequiredBeforePermitting { get; set; }

        public bool IsRequiredBeforeCertificate { get; set; }

        public bool IsReceived { get; set; }

        public bool IsExcluded { get; set; }

      
        public virtual ApplicationType ApplicationType { get; set; }



        public virtual MasterDocument MasterDocument { get; set; }
    }
}
