namespace EF_1.Model;

public class Category : BaseEntity
{
    public string CategoryName { get; set; } = null!;

    //Navigation prop
    public ICollection<Books>? Books { get; set; }
}
