namespace DemoAutofac
{
    public class CreateProcess : ICreateProcess
    {
        private readonly IOperation[] _createOperations;
        public CreateProcess
        (
            IOperation[] createOperations
        )
        {
            _createOperations = createOperations ?? throw new ArgumentNullException(nameof(createOperations));
        }
        public async Task ExecuteAsync()
        {
            foreach (var operation in _createOperations)
            {
                var executionResult = await operation.ExecuteAsync();
            }
        }
    }
}
