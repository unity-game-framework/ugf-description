using UGF.Description.Runtime;
using UnityEditor;

namespace UGF.Description.Editor
{
    [CustomEditor(typeof(DescriptionAsset), true)]
    public class DescriptionAssetEditor : UnityEditor.Editor
    {
        private readonly string[] m_propertyExclude = { "m_Script", "m_description" };
        private SerializedProperty m_propertyScript;

        protected virtual void OnEnable()
        {
            m_propertyScript = serializedObject.FindProperty("m_Script");
        }

        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();

            serializedObject.UpdateIfRequiredOrScript();

            DrawScript();
            DrawDescription();
            DrawInspector();

            serializedObject.ApplyModifiedProperties();

            EditorGUI.EndChangeCheck();
        }

        protected virtual void DrawScript()
        {
            using (new EditorGUI.DisabledScope(true))
            {
                EditorGUILayout.PropertyField(m_propertyScript, true, null);
            }
        }

        protected virtual void DrawDescription()
        {
            SerializedProperty propertyDescription = serializedObject.FindProperty("m_description");

            DescriptionEditorGUIUtility.DrawChildren(propertyDescription);
        }

        protected virtual void DrawInspector()
        {
            DrawPropertiesExcluding(serializedObject, m_propertyExclude);
        }
    }
}
