using UGF.Builder.Runtime;

namespace UGF.Description.Runtime
{
    public abstract class DescribedBuilderAsset<TArguments, TDescribed, TDescription> : BuilderAsset<TArguments, TDescribed>, IDescribedBuilder<TArguments>
        where TDescribed : class, IDescribed<TDescription>
        where TDescription : class, IDescription
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
