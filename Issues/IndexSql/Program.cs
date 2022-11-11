class Program
{
    static void Main(string[] args)
    {
        var context = new TestContext();

        for (int i = 0; i < 1000000; i++)
        {
            context.Todo.Add(new Todo
            {
                Name = $"TodoName{i}",
                Comment = $"Commment{i}",
                Content = $"Content{i}",
                Count = i,
            });
        }

        context.SaveChanges();
    }
}

