using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class TestContext : DbContext
{
    public virtual DbSet<Todo> Todo { get; set; }
    public virtual DbSet<Answer> Answer { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQL2019;Database=TestDB;Trusted_Connection=True;");
    }
}

[Index(nameof(Name), Name = "Nidx_Todo_Name")]
[Index(nameof(Comment), Name = "Nidx_Todo_Comment")]
//[Index(nameof(Name), nameof(Comment), Name = "Nidx_Todo_NameComment")]
public class Todo
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    public string Comment { get; set; }
    public string Content { get; set; }
    public int Count { get; set; }

    public virtual ICollection<Answer> Answer { get; set; }
}

public class Answer
{
    [Key]
    public int Id { get; set; }

    public virtual Todo Todo { get; set; }
}