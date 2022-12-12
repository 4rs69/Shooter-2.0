using OtherScripts;
using UnityEngine;

namespace WarriorScripts
{
    [RequireComponent(typeof(WarriorAnimationController))]
    [RequireComponent(typeof(HealthController))]
    [RequireComponent(typeof(WarriorController))]
    public class WarriorController : MonoBehaviour
    {
        [SerializeField]
        private CameraController _camera;
        private WarriorMoveController _warriorMove;
        private HealthController _healthController;
        private WarriorAnimationController _warriorAnimation;
    
        private void Awake()
        {
            _warriorAnimation = GetComponent<WarriorAnimationController>();
            _warriorMove = GetComponent<WarriorMoveController>();
            _healthController = GetComponent<HealthController>();
            _healthController.Died += OnDied;
        
        }
    
        private void OnDestroy()
        {
            if (_warriorAnimation != null)
            {
                _healthController.Died -= OnDied;
            }
        }

        private void OnDied()
        {
            _warriorAnimation.IsDied();
            _warriorMove.enabled = false;
            _camera.enabled = false;
        }
    }
}
