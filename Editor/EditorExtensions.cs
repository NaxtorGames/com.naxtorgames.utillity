namespace UnityEditor.Extensions
{
    public static class EditorExtensions
    {
        /// <summary>
        /// Draws a readonly Vector2Field with current window size.
        /// </summary>
        public static void DrawWindowSize(this EditorWindow editorWindow)
        {
            _ = EditorGUILayout.Vector2Field("Window Size:", editorWindow.position.size);
        }
    }
}
