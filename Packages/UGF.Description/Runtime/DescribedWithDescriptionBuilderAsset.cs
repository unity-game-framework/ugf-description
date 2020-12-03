using System;
using UGF.Builder.Runtime;

namespace UGF.Description.Runtime
{
    public abstract class DescribedWithDescriptionBuilderAsset<TDescribed, TDescription> : DescribedBuilderAsset<TDescribed>, IDescriptionBuilder
        where TDescribed : class, IDescribed
        where TDescription : class, IDescription
    {
        protected override TDescribed OnBuild()
        {
            TDescription description = OnBuildDescription();

            if (description == null) throw new ArgumentNullException(nameof(description), "Description can not be null.");

            return OnBuild(description);
        }

        protected abstract TDescription OnBuildDescription();
        protected abstract TDescribed OnBuild(TDescription description);

        T IBuilder<IDescription>.Build<T>()
        {
            return (T)(object)OnBuildDescription();
        }

        IDescription IBuilder<IDescription>.Build()
        {
            return OnBuildDescription();
        }
    }
}
