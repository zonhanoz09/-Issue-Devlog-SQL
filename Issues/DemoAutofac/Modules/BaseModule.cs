using Autofac;
using Autofac.Core;

namespace DemoAutofac.Modules
{
    public abstract class BaseModule : Module
    {
        protected ResolvedParameter GetChain<TAbstraction>(params string[] resolvingKeys)
        {
            return new ResolvedParameter(
                (pi, _) => pi.ParameterType == typeof(TAbstraction[]),
                (_, ctx) =>
                {
                    TAbstraction[] items = new TAbstraction[resolvingKeys.Length];
                    for (int index = 0; index < items.Length; index++)
                    {
                        items[index] = ctx.ResolveKeyed<TAbstraction>(resolvingKeys[index]);
                    }
                    return items;
                });
        }
    }
}
