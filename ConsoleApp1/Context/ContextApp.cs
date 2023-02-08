using EF_1.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_1.Context;
public class ContextApp : DbContext
{
#nullable disable
    public DbSet<Student> Students { get; set; }
    public DbSet<Authors> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<S_Card> S_Card { get; set; }

#nullable enable
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=R0Y4L;Initial Catalog=Bibliotheca;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        base.OnConfiguring(optionsBuilder);
    }
}