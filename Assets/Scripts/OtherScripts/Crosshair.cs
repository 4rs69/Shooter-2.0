using System;
using UnityEngine;
public class Crosshair : MonoBehaviour
{
    [SerializeField] 
    private float _currentSpread;

    [SerializeField]
    private float _speedSpread;

    [SerializeField]
    private Parts[] _parts;

    private float _time;
    private float _curSpread;
    private float _zoomInWhileWalking = 45;
    private float _zoomOut = 15;
    
    private void Update()
    {
        var spread = Input.GetKey(KeyCode.W) ? _zoomInWhileWalking : _zoomOut;
        CrosshairUpdate(spread);
    }
    
    private void CrosshairUpdate(float spead)
    {
        _time = 0.005f * _speedSpread;
        _curSpread = Mathf.MoveTowards(_curSpread, spead, _time);
        
       for (var i = 0; i < _parts.Length; i++)
       {
           var parts = _parts[i];
           parts._rectTransform.anchoredPosition = parts._position * _curSpread;
       }
    }
    
    [Serializable]
    private class Parts
    {
        public RectTransform _rectTransform; 
        public Vector2 _position;
    }
    
}
