using UnityEngine;

public class GunshotSound : StateMachineBehaviour
{
    [SerializeField]
    private AudioClip _audio;
    
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AudioSource.PlayClipAtPoint(_audio,animator.transform.position);
    }
}
