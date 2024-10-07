namespace Weaver.Permitting.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplicationTypeField : _BaseEntity
    {
        public long Id { get; set; }

        public long ApplicationTypeId { get; set; }

        [Required]
        [StringLength(500)]
        public string QuestionLabel { get; set; }

        [Required]
        [StringLength(255)]
        public string AnswerValue { get; set; }

        [Required]
        [StringLength(500)]
        public string NotesLabel { get; set; }

        [Required]
        [StringLength(255)]
        public string FieldType { get; set; }

        [Required]
        [StringLength(255)]
        public string CssClass { get; set; }

      
        public virtual ApplicationType ApplicationType { get; set; }


    }
}
