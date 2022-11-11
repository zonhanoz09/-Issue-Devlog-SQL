using DemoAutofac.Result;

namespace DemoAutofac.Steps
{
    public class Two : IOperation
    {
        public async Task<IExecutionResult> ExecuteAsync()
        {
            Console.WriteLine("Two");
            return ExecutionResult.DoneSuccessfully(nameof(Two));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
