using UnityEngine;

namespace WarriorScripts
{
    public class WarriorAnimationController : MonoBehaviour
    {
        private Animator _animator;
    
        private static readonly int WalkingFront = Animator.StringToHash("Walking");
        private static readonly int Shoot = Animator.StringToHash("Shoot");
        private static readonly int Dead = Animator.StringToHash("Dead");
        private static readonly int Idle = Animator.StringToHash("Idle");

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            ShootingAnimation();
        }

        public void WalkingAnimation()
        {
            _animator.SetBool(WalkingFront, Input.GetKey(KeyCode.W));
        }

        private void ShootingAnimation()
        {
            _animator.SetBool(Shoot,Input.GetMouseButtonDown(0));
        }

        public void IsDied()
        {
            _animator.SetTrigger(Dead);
        }

        public void IdleAnimation()
        {
            _animator.SetBool(Idle,true);
        }
    }
}