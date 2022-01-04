using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents
{
    public class ScriptableEventListener : MonoBehaviour
    {
        [SerializeField] private ScriptableEvent _eventNoPayload;
        [SerializeField] private UnityEvent _responseNoPayload; 

        private void OnEventRaised()
        {
            _responseNoPayload.Invoke();
        }

        private void OnEnable()
        {
            _eventNoPayload.Register(OnEventRaised);
        }

        private void OnDisable()
        {
            _eventNoPayload.Unregister(OnEventRaised);
        }
    }
}