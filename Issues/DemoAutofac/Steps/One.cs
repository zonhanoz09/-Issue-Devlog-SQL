using DemoAutofac.Result;

namespace DemoAutofac.Steps
{
    public class One : IOperation
    {
        public async Task<IExecutionResult> ExecuteAsync()
        {
            Console.WriteLine("One");
            return ExecutionResult.DoneSuccessfully(nameof(One));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
