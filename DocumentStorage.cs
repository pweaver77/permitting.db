namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocumentStorage : _BaseEntity
    {
      
        public DocumentStorage()
        {

            DocumentStorageFiles = new HashSet<DocumentStorageFile>();

        }


        public virtual ICollection<DocumentStorageFile> DocumentStorageFiles { get; set; }

      
    }
}
