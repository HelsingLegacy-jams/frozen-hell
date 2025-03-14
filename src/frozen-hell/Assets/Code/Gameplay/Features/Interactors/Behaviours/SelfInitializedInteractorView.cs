using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Interactors.Behaviours
{
  public class SelfInitializedInteractorView : MonoBehaviour
  {
    [SerializeField] private EntityBehaviour _entityView;
    
    [SerializeField] private string _title;
    [SerializeField] private InteractorTypeId _interactorTypeId;
    [SerializeField] private bool _isConsumable;

    private void Awake()
    {
      GameEntity entity = CreateEntity.Empty()
          .AddWorldPosition(transform.position)
          .AddTitle(_title)
          .AddInteractorTypeId(_interactorTypeId)

          .With(x=>x.isConsumable = _isConsumable)
        ;
      
      _entityView.SetEntity(entity);
    }
  }
}