using UnityEngine;

namespace Code.Gameplay.Features.Survivor.Behaviours
{
  public class SurvivorAnimator : MonoBehaviour
  {
    private readonly int _isMovingHash = Animator.StringToHash("isMoving");
    private readonly int _collectingHash = Animator.StringToHash("Collecting");
    private readonly int _breachingHash = Animator.StringToHash("Breaching");
    private readonly int _isPerformingActionHash = Animator.StringToHash("isPerformingAction");
    
    [SerializeField] private Animator _animator;

    public void ResetAbility() => _animator.SetBool(_isPerformingActionHash, false);
    public void PlayMove() => _animator.SetBool(_isMovingHash, true);
    public void PlayIdle() => _animator.SetBool(_isMovingHash, false);
    
    public void PlayBreaching()
    {
      _animator.SetBool(_isMovingHash, false);
      _animator.SetBool(_isPerformingActionHash, true);
      _animator.SetTrigger(_breachingHash);
    }
    
    public void PlayCollecting()
    {
      _animator.SetBool(_isMovingHash, false);
      _animator.SetBool(_isPerformingActionHash, true);
      _animator.SetTrigger(_collectingHash);
    }
  }
}