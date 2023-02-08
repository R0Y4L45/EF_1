using System.Diagnostics.CodeAnalysis;

namespace EF_1.Model;

public class S_Card
{
    public int? Id { get; set; } = null!;
    public int? StudentsId { get; set; } = null!;
    public int? BooksId { get; set; } = null!;

    [NotNull]
    public DateTime? TakenDate { get; set; } = DateTime.Now;
    public DateTime? ReturnedDate { get; set; } = null;

    //Navigation Prop
    public Books? Books { get; set; }
    public Student? Students { get; set; }
}
