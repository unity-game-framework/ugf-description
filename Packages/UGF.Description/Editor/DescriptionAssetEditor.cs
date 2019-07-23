using UGF.Description.Runtime;
using UnityEditor;

namespace UGF.Description.Editor
{
    [CustomEditor(typeof(DescriptionAssetBase), true)]
    internal class DescriptionAssetEditor : UnityEditor.Editor
    {
        private readonly string[] m_propertyExclude = { "m_Script", "m_description" };
        private SerializedProperty m_propertyScript;

        private void OnEnable()
        {
            m_propertyScript = serializedObject.FindProperty("m_Script");
        }

        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();

            serializedObject.UpdateIfRequiredOrScript();

            using (new EditorGUI.DisabledScope(true))
            {
                EditorGUILayout.PropertyField(m_propertyScript, true, null);
            }

            foreach (SerializedProperty serializedProperty in serializedObject.FindProperty("m_description"))
            {
                EditorGUILayout.PropertyField(serializedProperty, true, null);
            }

            DrawPropertiesExcluding(serializedObject, m_propertyExclude);

            serializedObject.ApplyModifiedProperties();

            EditorGUI.EndChangeCheck();
        }
    }
}
