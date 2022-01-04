using Asteroids;
using ScriptableEvents;
using UnityEngine;
using Variables;

namespace Ship
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Laser : MonoBehaviour
    {
        [SerializeField] private float _speed = 0.2f;
        [SerializeField] private IntReference _score;
        [SerializeField] private ScriptableEventInt _scoreUpdate;

        private Rigidbody2D _rigidbody;
        private float _lifetime;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    
        private void FixedUpdate()
        {
            var trans = transform;
            _rigidbody.MovePosition(trans.position + trans.up * _speed);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (string.Equals(other.tag, "Asteroid"))
            {
                _score.ApplyChange(-1);
                _scoreUpdate.Raise(_score.GetValue());
                Debug.Log($"Shots Fired. {_score.GetValue()} asteroids destroyed");
            }
        }
    }
}
