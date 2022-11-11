using Autofac;
using DemoAutofac;
using DemoAutofac.Modules;

public class Program
{
    public static void Main()
    {
        var builder = new ContainerBuilder();

        CompositionRoot.Build(builder);
        var container = builder.Build();

        var createProcess = container.Resolve<CreateProcess>();
        createProcess.ExecuteAsync();
    }
}