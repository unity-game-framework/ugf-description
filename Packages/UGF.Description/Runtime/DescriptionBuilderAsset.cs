using UGF.Builder.Runtime;
using UGF.Builder.Runtime.Assets;

namespace UGF.Description.Runtime
{
    public abstract class DescriptionBuilderAsset<TDescription> : BuilderAsset<TDescription>, IDescriptionBuilder where TDescription : class, IDescription
    {
        T IBuilder<IDescription>.Build<T>()
        {
            return (T)(object)Build();
        }

        IDescription IBuilder<IDescription>.Build()
        {
            return Build();
        }
    }
}
