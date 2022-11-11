using DevLog;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddScoped<GetService>();
        services.AddScoped<AddService>();
        services.AddTransient<TestContext>();
        ServiceProvider serviceProvider = services.BuildServiceProvider();

        var testService = serviceProvider.GetService<GetService>();
        var addService = serviceProvider.GetService<AddService>();
        var addTask = addService.Add();
        var displayTask = testService.Display();

        Task.WaitAll(addTask, displayTask);
    }
}

