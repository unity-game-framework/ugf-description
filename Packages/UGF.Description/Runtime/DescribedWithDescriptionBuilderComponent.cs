using System;
using UGF.Builder.Runtime;

namespace UGF.Description.Runtime
{
    public abstract class DescribedWithDescriptionBuilderComponent<TArguments, TDescribed, TDescription> : DescribedBuilderComponent<TArguments, TDescribed, TDescription>, IDescriptionBuilder
        where TDescribed : class, IDescribed<TDescription>
        where TDescription : class, IDescription
    {
        protected override TDescribed OnBuild(TArguments arguments)
        {
            TDescription description = OnBuildDescription();

            if (description == null) throw new ArgumentNullException(nameof(description), "Description can not be null.");

            return OnBuild(arguments, description);
        }

        protected abstract TDescription OnBuildDescription();
        protected abstract TDescribed OnBuild(TArguments arguments, TDescription description);

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
