using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

public class TestContext : DbContext
{
    public virtual DbSet<Todo> Todo { get; set; }
    public virtual DbSet<Answer> Answer { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQL2019;Database=TestDB;Trusted_Connection=True;");
    }
}

public class Todo
{
    public int Id { get; set; }

    [InverseProperty("Todo")]
    public virtual ICollection<Answer> Answer { get; set; }
}

public class Answer
{
    public int Id { get; set; }
    //public int TodoId { get; set; }
    //[ForeignKey(nameof(TodoId))]
    //[InverseProperty("Answer")]
    public virtual Todo Todo { get; set; }
}