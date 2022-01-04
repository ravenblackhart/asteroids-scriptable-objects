using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents
{
    public abstract class ScriptableEventListener_Abs<T> : MonoBehaviour
    {
        [SerializeField] private ScriptableEvent<T> _event;
        [SerializeField] private UnityEvent<T> _response; 

        private void OnEventRaised(T newValue)
        {
            _response.Invoke(newValue);
        }

        private void OnEnable()
        {
            _event.Register(OnEventRaised);
        }

        private void OnDisable()
        {
            _event.Unregister(OnEventRaised);
        }
    }
}