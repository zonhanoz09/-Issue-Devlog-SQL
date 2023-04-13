using Microsoft.EntityFrameworkCore;

namespace DevLog
{
    public class GetService
    {
        private TestContext _dbContext;
        public GetService(TestContext context)
        {
            _dbContext = context;
        }

        public async Task Display()
        {
            var todos = await (from todo in _dbContext.Todo
                              select new Todo
                              {
                                  Id = todo.Id
                              }).ToListAsync();
            foreach (var todo in todos)
            {
                Console.WriteLine($"Todo id: {todo.Id}");
            } 
        }
    }
}
