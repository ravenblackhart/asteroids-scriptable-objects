using UnityEditor;
using UnityEngine;

namespace ScriptableEvents.Editor
{

    [CustomEditor(typeof(ScriptableEventBase))]
    public class ScriptableEventEditor : UnityEditor.Editor
    {
        private ScriptableEventBase _target;
        public override void OnInspectorGUI()
        {
            _target = (ScriptableEventBase) target; 
            base.OnInspectorGUI();


            if (GUILayout.Button("Press This"))
            {
                _target.Raise();
                Debug.Log("You  Pressed da button");
            }
        }
    }
}