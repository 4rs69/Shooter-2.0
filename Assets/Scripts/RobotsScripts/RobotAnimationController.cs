using UnityEngine;

public class RobotAnimationController : MonoBehaviour
{
    private Animator _animator;
    
    private static readonly int WalkingFront = Animator.StringToHash("WalkingFront");
    private static readonly int WalkingBack = Animator.StringToHash("WalkingBack");
    private static readonly int WalkingRight = Animator.StringToHash("WalkingRight");
    private static readonly int WalkingLeft = Animator.StringToHash("WalkingLeft");
    private static readonly int Run = Animator.StringToHash("Run");
    private static readonly int Jump = Animator.StringToHash("Jump");
    private static readonly int Shoot = Animator.StringToHash("Shoot");
    private static readonly int Dead = Animator.StringToHash("Dead");
    private static readonly int Idle = Animator.StringToHash("Idle");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        JumpAnimation();
        ShootingAnimation();
    }

    public void WalkingAnimation()
    {
        _animator.SetBool(WalkingFront, Input.GetKey(KeyCode.W));
        _animator.SetBool(WalkingBack, Input.GetKey(KeyCode.S));
        _animator.SetBool(WalkingRight, Input.GetKey(KeyCode.D));
        _animator.SetBool(WalkingLeft, Input.GetKey(KeyCode.A));
    }

    public void RunAnimation(bool t)
    {
        _animator.SetBool(Run,t);
    }
    
    private void JumpAnimation()
    {
        _animator.SetBool(Jump,Input.GetKeyDown(KeyCode.Space));
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
