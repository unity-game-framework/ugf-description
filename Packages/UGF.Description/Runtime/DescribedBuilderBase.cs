using UGF.Builder.Runtime;

namespace UGF.Description.Runtime
{
    public abstract class DescribedBuilderBase<TArguments, TDescribed> : Builder<TArguments, TDescribed>, IDescribedBuilder<TArguments> where TDescribed : class, IDescribed
    {
        T IBuilder<TArguments, IDescribed>.Build<T>(TArguments arguments)
        {
            return (T)(object)OnBuild(arguments);
        }

        IDescribed IBuilder<TArguments, IDescribed>.Build(TArguments arguments)
        {
            return OnBuild(arguments);
        }
    }
}
