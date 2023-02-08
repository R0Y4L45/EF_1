using EF_1.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EF_1.Model;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }

    [NotNull]
    public StatusEnum.Status Status { get; set; }

    [NotNull]
    public DateTime? CreateDate { get; set; } = DateTime.Now;

    [NotNull]
    public DateTime? ModifiedDate { get; set; }
}
