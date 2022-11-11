using System;
using System.Threading.Tasks;
using DemoAutofac.Result;

namespace DemoAutofac
{
    public interface IOperation : IDisposable
    {
        Task<IExecutionResult> ExecuteAsync();
    }
}
