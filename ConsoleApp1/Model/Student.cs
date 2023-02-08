using System.Diagnostics.CodeAnalysis;
using EF_1.Enums;

namespace EF_1.Model;

public class Student : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;

    [NotNull]
    public int? SchoolNumber { get; set; } = null!;
    public GenderEnum.Gender? Gender { get; set; } = null!;
    public DateTime Birthday { get; set; }

    public ICollection<S_Card>? S_Cards { get; set; }
}
