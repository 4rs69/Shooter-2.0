using UnityEngine;

namespace RobotsScripts
{
    public  class RobotMoveController : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 3;

        [SerializeField]
        private float _speedValue = 3;

        [SerializeField]
        private float _speedAcceleration = 5;

        private RobotAnimationController _animation;

        private void Awake()
        {
            _animation = GetComponent<RobotAnimationController>();
        }

        private void Update()
        {
            var isRunKeyPressed = Input.GetKey(KeyCode.LeftShift);
            _speed = isRunKeyPressed ? _speedAcceleration : _speedValue;

            var vertical = Input.GetAxis("Vertical"); // A D
            var horizontal = Input.GetAxis("Horizontal"); // W S

            var move = (transform.forward * vertical + transform.right * horizontal).normalized;
            var moveDelta = move * _speed * Time.deltaTime;
            transform.Translate(moveDelta, Space.World);
        
            if (moveDelta.sqrMagnitude < Mathf.Epsilon)
            {
                _animation.IdleAnimation();
                return;
            }
        
            if (isRunKeyPressed)
            {
                _animation.RunAnimation(true);
            }
            else
            {
                _animation.WalkingAnimation();
                _animation.RunAnimation(false);
            }
        
        }
    }
}
