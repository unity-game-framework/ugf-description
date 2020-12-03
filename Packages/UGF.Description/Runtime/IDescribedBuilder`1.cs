using UGF.Builder.Runtime;

namespace UGF.Description.Runtime
{
    public interface IDescribedBuilder<in TArguments> : IBuilder<TArguments, IDescribed>
    {
    }
}
