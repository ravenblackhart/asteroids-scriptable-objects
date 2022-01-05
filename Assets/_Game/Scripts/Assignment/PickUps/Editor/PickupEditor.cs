using Assignment.PickUps;
using UnityEditor;
using UnityEngine;

namespace Assignment.Editor
{
    [CustomEditor(typeof(Pickup))]
    public class PickupEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Press This"))
            {
                Debug.Log("You  Pressed da button");
            }
        }
    }
}