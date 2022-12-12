using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationController : MonoBehaviour
{
    private Animator _animator;
    
    private static readonly int Walking = Animator.StringToHash("Walking");
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void WalkingEnemy()
    {
        _animator.SetBool(Walking,true);
    }
}
