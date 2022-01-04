using UnityEngine;
using Variables;

namespace Ship
{
    public class Health : MonoBehaviour
    {
        private int _health;
        
        private const int MIN_HEALTH = 0;
        
        public void TakeDamage(int damage)
        { 
            Debug.Log("Took some damage");
            _health = Mathf.Max(MIN_HEALTH, _health - damage);
        }
    }
}
