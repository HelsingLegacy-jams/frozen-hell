using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Statuses.Behaviours
{
  public class SelfInitializedStatusesView : MonoBehaviour
  {
    [SerializeField] private EntityBehaviour _entityView;
    [SerializeField] private StatusView _hunger;
    [SerializeField] private StatusView _thirst;
    [SerializeField] private StatusView _cold;

    private void Awake()
    {
      List<StatusView> list = 
        new (){ _hunger, _thirst, _cold };

      GameEntity entity = CreateEntity.Empty()
          .AddStatusViews(list)
          
          .AddHungerView(_hunger)
          .AddThirstView(_thirst)
          .AddColdView(_cold)
          
          .AddStarterCondition(0f)
          .AddIncrement(2f)
          .AddDeadlyCondition(1f)
          
          .With(x => x.isReadyToResetHunger = true)
          .With(x => x.isReadyToResetThirst = true)
          .With(x => x.isReadyToResetCold = true)
        ;

      _entityView.SetEntity(entity);
    }
  }
}