using UnityEditor;

namespace UGF.Description.Editor
{
    public static class DescriptionEditorGUIUtility
    {
        public static void DrawChildren(SerializedProperty serializedProperty)
        {
            SerializedProperty propertyEnd = serializedProperty.GetEndProperty();

            serializedProperty.NextVisible(true);

            if (!SerializedProperty.EqualContents(serializedProperty, propertyEnd))
            {
                EditorGUILayout.PropertyField(serializedProperty, true);

                while (serializedProperty.NextVisible(false) && !SerializedProperty.EqualContents(serializedProperty, propertyEnd))
                {
                    EditorGUILayout.PropertyField(serializedProperty, true, null);
                }
            }
        }
    }
}
