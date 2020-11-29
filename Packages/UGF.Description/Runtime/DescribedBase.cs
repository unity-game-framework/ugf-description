using System;

namespace UGF.Description.Runtime
{
    public abstract class DescribedBase<TDescription> : IDescribed<TDescription> where TDescription : class, IDescription
    {
        public TDescription Description { get; }

        IDescription IDescribed.Description { get { return Description; } }

        protected DescribedBase(TDescription description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
    }
}
