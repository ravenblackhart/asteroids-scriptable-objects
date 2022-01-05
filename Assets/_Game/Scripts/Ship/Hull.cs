using Assignment.PickUps;
using ScriptableEvents;
using UnityEngine;
using Variables;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        [SerializeField] private IntReference _health; 
        [SerializeField] private ScriptableEventInt _onHealthChangeEvent;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
                _health.ApplyChange(-1);
                _onHealthChangeEvent.Raise(_health.GetValue());
               Debug.Log($"Got hit. Health now {_health.GetValue()}");
            }
            
        }

    }
}
