namespace UGF.Description.Runtime
{
    public interface IDescribed<out TDescription> : IDescribed where TDescription : class, IDescription
    {
        TDescription Description { get; }
    }
}
