using UnityEngine;

namespace UGF.Description.Runtime
{
    public abstract class DescriptionAsset : ScriptableObject
    {
        public T GetDescription<T>() where T : IDescription
        {
            return (T)GetDescription();
        }

        public abstract IDescription GetDescription();
    }
}
