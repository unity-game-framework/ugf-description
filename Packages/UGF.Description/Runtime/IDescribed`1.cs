namespace UGF.Description.Runtime
{
    public interface IDescribed<out TDescription> : IDescribed where TDescription : class, IDescription
    {
        new TDescription Description { get; }
    }
}
