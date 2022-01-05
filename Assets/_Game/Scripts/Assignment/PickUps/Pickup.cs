using System;
using UnityEngine;
using Variables;

namespace Assignment.PickUps
{
    [CreateAssetMenu(fileName = "new PickUp", menuName = "ScriptableObjects/Pickup")]
    public class Pickup : ScriptableObject
    {
        public enum PickUpTypes
        {
            Health,
            Speed,
            Shield
        }
        
        public PickUpTypes PickUpType;
        public int ModifierValue; 
        public Sprite Sprite;
        

    }
}