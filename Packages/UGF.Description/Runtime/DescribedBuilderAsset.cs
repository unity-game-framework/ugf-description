using UGF.Builder.Runtime;

namespace UGF.Description.Runtime
{
    public abstract class DescribedBuilderAsset<TDescribed> : BuilderAsset<TDescribed>, IDescribedBuilder where TDescribed : class, IDescribed
    {
        T IBuilder<IDescribed>.Build<T>()
        {
            return (T)(object)OnBuild();
        }

        IDescribed IBuilder<IDescribed>.Build()
        {
            return OnBuild();
        }
    }
}
