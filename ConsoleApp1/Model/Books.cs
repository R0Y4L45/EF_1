using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace EF_1.Model;

public class Books : BaseEntity
{
    //Prop
    public string Name { get; set; } = null!;
    public int? PageCount { get; set; } = null!;

    // FK
    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; } = null!;
    public Category? Category { get; set; }

    //Navigation prop
    public ICollection<Authors>? Authors { get; set; }
    public ICollection<S_Card>? S_Cards { get; set; }
}
