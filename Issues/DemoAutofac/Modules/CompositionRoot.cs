using Autofac;

namespace DemoAutofac.Modules
{
    public static class CompositionRoot
    {
        public static void Build(ContainerBuilder container)
        {
            container.RegisterModule<CreateModule>();

        }
    }
}
