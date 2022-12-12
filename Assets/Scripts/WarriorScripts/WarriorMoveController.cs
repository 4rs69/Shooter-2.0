using UnityEngine;

namespace WarriorScripts
{
    public  class WarriorMoveController : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 3;
    
        private WarriorAnimationController _animation;

        private void Awake()
        {
            _animation = GetComponent<WarriorAnimationController>();
        }

        private void Update()
        {
            var vertical = Input.GetAxis("Vertical"); // A D
            var horizontal = Input.GetAxis("Horizontal"); // W S

            var move = (transform.forward * vertical + transform.right * horizontal).normalized;
            var moveDelta = move * _speed * Time.deltaTime;
            transform.Translate(moveDelta, Space.World);
        
            if (moveDelta.sqrMagnitude < Mathf.Epsilon)
            {
                _animation.IdleAnimation();
            }
            else
            {
                _animation.WalkingAnimation();
            }
        
        }

    }
}