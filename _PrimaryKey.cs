using System.ComponentModel.DataAnnotations;

namespace Weaver.Permitting.DB
{

    public abstract class _PrimaryKey
    {
        [Key]
        long Id { get; set; }
    }
}