using UnityEngine;

namespace UGF.Description.Runtime
{
    public abstract class DescriptionAssetBase : ScriptableObject
    {
        public abstract IDescription GetDescription();
    }
}
