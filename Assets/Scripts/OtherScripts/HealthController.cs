using System;
using UnityEngine;

namespace OtherScripts
{
    public class HealthController : MonoBehaviour
    {
        public Action HealthChanged;
    
        public Action Died;
        private bool IsAlive => _currentHealth > 0;

        public int MaxHealth => (int)_startHealth;
        public float _currrentHealth => (int)_currentHealth;
    
        [SerializeField]
        private float _startHealth = 100f;

        [SerializeField]
        private float _currentHealth;
    
        private void Awake()
        {
            _currentHealth = _startHealth;
        }

        public void TakeDamage(int damage)
        {
            if (!IsAlive)
            {
                return;
            }
            
            _currentHealth -= damage;
            HealthChanged?.Invoke();
        
            if (_currentHealth <= 0)
            {
                Died?.Invoke();
            }
        }
    }
}
