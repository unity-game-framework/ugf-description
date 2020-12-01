using System;

namespace UGF.Description.Runtime
{
    public abstract class DescribedBase<TDescription> : IDescribed<TDescription> where TDescription : class, IDescription
    {
        public TDescription Description { get; }

        protected DescribedBase(TDescription description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        public T GetDescription<T>() where T : class, IDescription
        {
            return (T)GetDescription();
        }

        public IDescription GetDescription()
        {
            return Description;
        }
    }
}
