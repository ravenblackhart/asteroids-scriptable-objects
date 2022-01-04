using System;
using UnityEngine;

namespace Variables
{
    [CreateAssetMenu(fileName = "new IntVariable", menuName = "ScriptableObjects/IntVariable")]
    public class IntVariable : ScriptableObject
    {
        [SerializeField] private int _intValue;
        private int _currentIntValue; 
        public int IntValue => _currentIntValue;

        public void ApplyChange(int change)
        {
            _currentIntValue += change;
        }

        private void OnEnable()
        {
            _currentIntValue = _intValue;
        }
    }
}