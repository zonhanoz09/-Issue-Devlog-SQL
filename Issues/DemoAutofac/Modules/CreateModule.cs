using Autofac;
using DemoAutofac.Modules;
using DemoAutofac.Steps;

namespace DemoAutofac.Modules
{
    public class CreateModule : BaseModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<One>()
                .As<IOperation>()
                .Keyed<IOperation>(nameof(One));

            builder.RegisterType<Two>()
                .As<IOperation>()
                .Keyed<IOperation>(nameof(Two));

            //---
            builder.RegisterType<CreateProcess>()
               .InstancePerLifetimeScope()
               .WithParameter(GetChain<IOperation>(
                   nameof(One),
                   nameof(Two)
               ));
        }
    }
}
