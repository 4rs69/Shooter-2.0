using UnityEngine;

namespace OtherScripts
{
   public class Bullet : MonoBehaviour
   {
      [SerializeField]
      private Rigidbody _rigidbody;

      [SerializeField]
      private float _speed;

      [SerializeField]
      private int _damage = 50;
   
      public void Initialize(Vector3 muzzleForward)
      {
         _rigidbody.velocity = muzzleForward * _speed;
      }

      public void OnCollisionEnter(Collision other)
      {
         var otherHealth = other.gameObject.GetComponent<HealthController>();
         if (otherHealth != null)
         {
            otherHealth.TakeDamage(_damage);
         }
      
         Destroy(gameObject);
      }
   }
}
