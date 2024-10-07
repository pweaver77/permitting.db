namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ElectricalCodeEdition : _BaseEntity
    {
  
        public ElectricalCodeEdition()
        {
            
        }

      

        [Required]
        public string EditionName { get; set; }

        public bool IsActive { get; set; }

      
    }
}
