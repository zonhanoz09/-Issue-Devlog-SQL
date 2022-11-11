namespace DemoAutofac.Result
{
    public class ExecutionResult : IExecutionResult
    {
        private string operationName;

        public ExecutionResult(string operationName)
        {
            this.operationName = operationName;
        }

        public static ExecutionResult DoneSuccessfully(string operationName)
        {
            return new ExecutionResult(operationName);
        }
    }
}
