using UnityEngine;

namespace Code.Gameplay.Features.Survivor.Behaviours
{
  public class SurvivorAnimator : MonoBehaviour
  {
    private readonly int _isMovingHash = Animator.StringToHash("isMoving");
    private readonly int _collectingHash = Animator.StringToHash("Collecting");
    private readonly int _breachingHash = Animator.StringToHash("Breaching");
    private readonly int _isPerformingActionHash = Animator.StringToHash("isPerformingAction");
    
    public Animator Animator;

    public void ResetAbility() => Animator.SetBool(_isPerformingActionHash, false);
    public void PlayMove() => Animator.SetBool(_isMovingHash, true);
    public void PlayIdle() => Animator.SetBool(_isMovingHash, false);
    
    public void PlayBreaching()
    {
      Animator.SetBool(_isPerformingActionHash, true);
      Animator.SetTrigger(_breachingHash);
    }
    
    public void PlayCollecting()
    {
      Animator.SetBool(_isPerformingActionHash, true);
      Animator.SetTrigger(_collectingHash);
    }
  }
}