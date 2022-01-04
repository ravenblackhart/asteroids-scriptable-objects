using System;
using ScriptableEvents;
using TMPro;
using UnityEngine;
using Variables;

namespace UI
{
    public class UI : MonoBehaviour
    {
        [Header("UI Elements")]
        [SerializeField] private TextMeshProUGUI _healthText;
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private TextMeshProUGUI _timerText;
        [SerializeField] private TextMeshProUGUI _laserText;

        [Header("Data")] 
        [SerializeField] private IntReference _health;

        [SerializeField] private ScriptableEventInt _onHealthChangeEvent; 


        private void OnEnable()
        {
            _onHealthChangeEvent.Register(OnHealthChange);
        }

        private void OnDisable()
        {
            _onHealthChangeEvent.Unregister(OnHealthChange);
        }

        private void Start()
        {
            SetHealthText($"Health : {_health.GetValue()}");
        }

        private void SetHealthText(string text)
        {
            _healthText.text = text;
        }

        private void SetScoreText(string text)
        {
            _scoreText.text = text;
        }
        
        private void SetTimerText(string text)
        {
            _timerText.text = text;
        }
        
        private void SetLaserText(string text)
        {
            _laserText.text = text;
        }
        
        public void OnHealthChange(int newValue)
        {
            SetHealthText($"Health : {newValue}");
        }
    }
}
