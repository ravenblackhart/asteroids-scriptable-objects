using System;
using ScriptableEvents;
using UnityEngine;
using UnityEditor;
using Variables;
using Random = UnityEngine.Random;

namespace Assignment.PickUps
{
    public class PickupComponent : MonoBehaviour
    {
        [Tooltip("This field accepts Scriptable Objects of the type <PickUp>")]public Pickup Pickup;
        private Vector2 spawnPos; 
        private int xPos;
        private int yPos;
        
        [SerializeField] private IntReference _health; 
        [SerializeField] private ScriptableEventInt _onHealthChangeEvent;
        
        private void OnEnable()
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Pickup.Sprite;
        }
        
        
        public void Start()
        {
            xPos = Random.Range(-6, 6);
            yPos = Random.Range(-4, 4);

            spawnPos = new Vector2(xPos, yPos); 
            
            gameObject.transform.position = spawnPos;
            gameObject.tag = "PickUp"; 
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                if (Pickup.PickUpType.ToString() == "Health")
                {
                    _health.ApplyChange(+Pickup.ModifierValue); 
                    _onHealthChangeEvent.Raise(_health.GetValue());
                    
                    Debug.Log($"Boost Get. Health now {_health.GetValue()}");
                }
                
            }
            
            Destroy(gameObject);
        }
    }
}