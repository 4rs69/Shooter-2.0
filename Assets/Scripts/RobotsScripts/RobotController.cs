using OtherScripts;
using UnityEngine;

namespace RobotsScripts
{
    [RequireComponent(typeof(RobotAnimationController))]
    [RequireComponent(typeof(HealthController))]
    [RequireComponent(typeof(RobotMoveController))]
    public class RobotController : MonoBehaviour
    {
        [SerializeField]
        private CameraController _camera;
    
        private RobotMoveController _robotMove;
        private HealthController _healthController;
        private RobotAnimationController _robotAnimation;
    
        private void Awake()
        {
            _robotAnimation = GetComponent<RobotAnimationController>();
            _robotMove = GetComponent<RobotMoveController>();
            _healthController = GetComponent<HealthController>();
            _healthController.Died += OnDied;
        
        }
    
        private void OnDestroy()
        {
            if (_robotAnimation != null)
            {
                _healthController.Died -= OnDied;
            }
        }

        private void OnDied()
        {
            _robotAnimation.IsDied();
            _robotMove.enabled = false;
            _camera.enabled = false;
        }
    }
}
