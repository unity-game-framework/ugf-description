using UGF.Builder.Runtime;

namespace UGF.Description.Runtime
{
    public abstract class DescriptionBuilder<TDescription> : Builder<TDescription>, IDescriptionBuilder where TDescription : class, IDescription
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
