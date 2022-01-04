using System;
using UnityEngine;

namespace Variables
{
    [Serializable]
    public class IntReference
    {
        [SerializeField] private IntVariable _intVariable;
        [SerializeField] private int _simpleValue;
        [SerializeField] private bool _useSimple;

        public int GetValue()
        {
            return _useSimple ? _simpleValue : _intVariable.IntValue; 

        }

        public void ApplyChange(int change)
        {
            if (_useSimple) _simpleValue += change; 
            else _intVariable.ApplyChange(change);
        }
    }
}