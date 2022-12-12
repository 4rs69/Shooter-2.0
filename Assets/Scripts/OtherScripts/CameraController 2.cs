using UnityEngine;

namespace OtherScripts
{
    public class CameraController2 : MonoBehaviour
    {
        [SerializeField]
        private float _mouseSensivity = 1000f;

        [SerializeField]
        private Transform _player;
    
        private float xRotation;

        private void Update()
        {
            var mouseX = Input.GetAxis("Mouse X") * _mouseSensivity * Time.deltaTime;
            var mouseY = Input.GetAxis("Mouse Y") * _mouseSensivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -25f, 25f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            _player.Rotate(Vector3.up * mouseX);
        }
    }
}
