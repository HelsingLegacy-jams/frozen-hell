using Code.Common.Entity;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Common.Time.Behaviours
{
  public class SelfInitializedTimerView : MonoBehaviour
  {
    [SerializeField] private EntityBehaviour _entityView;
    [SerializeField] private RescueCountdown _countdownTimer;

    private void Awake()
    {
      GameEntity entity = CreateEntity.Empty()
          .AddRescueCountdown(_countdownTimer)
          
          .AddTime(180f)
          .AddMaxTime(180f)
          .AddMinutes(3)
          .AddSeconds(0)
        ;
        
      _entityView.SetEntity(entity);
    }
  }
}