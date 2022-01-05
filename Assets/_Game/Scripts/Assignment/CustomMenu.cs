using Assignment.PickUps;
using Ship;
using UnityEditor;
using UnityEngine;

    public class CustomMenu : MonoBehaviour
    {
        [MenuItem("GameObject/Custom Objects/Pickup", false, 10)]

        static void CreateCustomPickup(MenuCommand menuCommand)
        {
            GameObject go = new GameObject("new Pickup");
            go.AddComponent<PickupComponent>(); 
            go.AddComponent<SpriteRenderer>();
            go.AddComponent<Rigidbody2D>();
            go.AddComponent<CircleCollider2D>();

            //Ensure proper parenting & register to undo system
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
            Selection.activeObject = go;
        }
        
    }