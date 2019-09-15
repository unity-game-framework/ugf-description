using UnityEngine;

namespace UGF.Description.Runtime
{
    public abstract class DescriptionAsset<TDescription> : DescriptionAsset where TDescription : IDescription
    {
        [SerializeField] private TDescription m_description;

        public TDescription Description { get { return m_description; } set { m_description = value; } }

        public override IDescription GetDescription()
        {
            return m_description;
        }
    }
}
