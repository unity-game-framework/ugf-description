namespace UGF.Description.Runtime
{
    public interface IDescribed
    {
        T GetDescription<T>() where T : class, IDescription;
        IDescription GetDescription();
    }
}
