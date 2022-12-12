using OtherScripts;
using UnityEngine;

namespace EnemyScripts
{
    public class MeleeDamageEnemy : MonoBehaviour
    {
        [SerializeField] 
        private int _damageValue = 10;
    
        public void OnCollisionEnter(Collision other)
        {
            var healthController = other.gameObject.GetComponent<HealthController>();
       
            if (healthController != null)
            {
                healthController.TakeDamage(_damageValue);
            }
        }
    }
}
