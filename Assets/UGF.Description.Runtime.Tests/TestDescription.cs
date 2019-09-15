using System;
using System.Collections.Generic;
using UnityEngine;

namespace UGF.Description.Runtime.Tests
{
    [Serializable]
    public class TestDescription : IDescription
    {
        [SerializeField] private bool m_boolValue = true;
        [SerializeField] private int m_intValue = 10;
        [SerializeField] private float m_floatValue = 10.5F;
        [SerializeField] private TypeCode m_enumValue = TypeCode.Boolean;
        [SerializeField] private List<Vector4> m_list = new List<Vector4>();

        public bool BoolValue { get { return m_boolValue; } set { m_boolValue = value; } }
        public int IntValue { get { return m_intValue; } set { m_intValue = value; } }
        public float FloatValue { get { return m_floatValue; } set { m_floatValue = value; } }
        public TypeCode EnumValue { get { return m_enumValue; } set { m_enumValue = value; } }
        public List<Vector4> List { get { return m_list; } }
    }
}
