using UGF.Builder.Runtime;

namespace UGF.Description.Runtime
{
    public abstract class DescribedBuilderAsset<TDescribed> : BuilderAsset<TDescribed>, IDescribedBuilder where TDescribed : class, IDescribed
    {
        IDescribed IBuilder<IDescribed>.Build()
        {
            return OnBuild();
        }
    }
}
