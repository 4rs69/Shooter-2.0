using System;
using UnityEngine;
using UnityEngine.UI;

public class WeaponController : MonoBehaviour
{
    [SerializeField]
    private Weapon _weapon;


    private void Awake()
    {
       //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
       // var raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
//
       // if (Physics.Raycast(raycast,out var hitInfo))
       // {
       //     var s = hitInfo.point;
       //     if (Input.GetMouseButtonDown(0))
       //     {
       //         _weapon.Shoot(s);
       //     }
       // }
        if (Input.GetMouseButtonDown(0))
        {
            _weapon.Shoot();
        }
       
    }
}
