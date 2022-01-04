using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new FloatVariable", menuName="ScriptableObjects/FloatVariable")]
public class FloatVariable : ScriptableObject
{
    [Range(0f, 10f)]
    [SerializeField] private float _floatValue;
    public float FloatValue => _floatValue;

}
