using UGF.Builder.Runtime;

namespace UGF.Description.Runtime
{
    public abstract class DescriptionBuilderBase<TDescription> : Builder<TDescription>, IDescriptionBuilder where TDescription : class, IDescription
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
