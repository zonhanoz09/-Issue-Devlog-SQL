namespace DevLog
{
    public class AddService
    {
        private TestContext _dbContext;
        public AddService(TestContext context)
        {
            _dbContext = context;
        }

        public async Task Add()
        {
            _dbContext.Todo.Add(new Todo());
            Thread.Sleep(1000);
            await _dbContext.SaveChangesAsync();
        }
    }
}
