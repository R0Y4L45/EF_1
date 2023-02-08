using System.ComponentModel.DataAnnotations.Schema;
using EF_1.Enums;

namespace EF_1.Model;

public class Authors : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public GenderEnum.Gender? Gender { get; set; } = null!;

    //Navigation Prop
    public ICollection<Books>? Books { get; set; }
}
