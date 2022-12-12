using UnityEngine;
using UnityEngine.UI;

namespace OtherScripts
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField]
        private Slider _healthBar;
    
        [SerializeField]
        private HealthController _healthController;

        [SerializeField]
        private GameObject _fillArea;
    

        private void Start()
        {
            _healthController.HealthChanged += OnHealthChanged;
            OnHealthChanged();
        }

        private void  OnHealthChanged()
        { 
            _healthBar.value = _healthController._currrentHealth / _healthController.MaxHealth;
         
            if (_healthBar.value <= 0)
            {
                _fillArea.SetActive(false);
                _healthController.HealthChanged -= OnHealthChanged;
            }
        }
    }
}