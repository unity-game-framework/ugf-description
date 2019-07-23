using System;
using UnityEngine;

namespace UGF.Description.Runtime.Tests
{
    [CreateAssetMenu(menuName = "Tests/TestDescriptionAsset")]
    public class TestDescriptionAsset : DescriptionAsset<TestDescription>
    {
        [SerializeField] private bool m_boolValue = true;
        [SerializeField] private int m_intValue = 10;
        [SerializeField] private float m_floatValue = 10.5F;
        [SerializeField] private TypeCode m_enumValue = TypeCode.Boolean;

        public bool BoolValue { get { return m_boolValue; } set { m_boolValue = value; } }
        public int IntValue { get { return m_intValue; } set { m_intValue = value; } }
        public float FloatValue { get { return m_floatValue; } set { m_floatValue = value; } }
        public TypeCode EnumValue { get { return m_enumValue; } set { m_enumValue = value; } }
    }
}
