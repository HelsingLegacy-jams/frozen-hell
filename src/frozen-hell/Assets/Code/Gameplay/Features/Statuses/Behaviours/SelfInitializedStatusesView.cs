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
    [SerializeField] private List<StatusView> _statusViews;

    private void Awake()
    {
      var views = new List<IStatusView>();
      foreach (StatusView view in _statusViews) 
        views.Add(view);
      
      GameEntity entity = CreateEntity.Empty()
          .AddStatusViews(views)
          
          .AddStarterCondition(0f)
          .AddIncrement(2f)
          .AddDeadlyCondition(1f)
          
          .With(x=>x.isNotInitialized = true)
        ;
      
      _entityView.SetEntity(entity);
    }
  }
}