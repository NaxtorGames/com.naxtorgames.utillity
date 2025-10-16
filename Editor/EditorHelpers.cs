using Object = UnityEngine.Object;
using SerializedObject = UnityEditor.SerializedObject;
using SerializedProperty = UnityEditor.SerializedProperty;
using EditorGUILayout = UnityEditor.EditorGUILayout;

namespace NaxtorGames.Utilities.EditorScripts
{
    public static class EditorHelpers
    {
        public static SerializedProperty CreatePropertyField(Object serializedObject, string fieldName)
        {
            SerializedObject serializedPropertyField = GetSerializedObject(serializedObject);
            return CreatePropertyField(serializedPropertyField, fieldName);
        }

        public static SerializedProperty CreatePropertyField(SerializedObject serializedObject, string fieldName)
        {
            return serializedObject.FindProperty(fieldName);
        }

        public static SerializedObject GetSerializedObject(Object serializingObject)
        {
            return new SerializedObject(serializingObject);
        }

        public static void PropertyField(Object serializingObject, string variableNameAsString, bool includeChildren = false)
        {
            SerializedObject serializedPropertyField = GetSerializedObject(serializingObject);
            serializedPropertyField.Update();
            _ = EditorGUILayout.PropertyField(serializedPropertyField.FindProperty(variableNameAsString), includeChildren);
            _ = serializedPropertyField.ApplyModifiedProperties();
        }

        public static void DrawPropertyField(SerializedProperty serializedProperty, bool includeChildren = false)
        {
            _ = EditorGUILayout.PropertyField(serializedProperty, includeChildren);
        }
    }
}