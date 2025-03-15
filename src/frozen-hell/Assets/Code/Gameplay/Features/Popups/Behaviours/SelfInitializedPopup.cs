using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Popups.Behaviours
{
  public class SelfInitializedPopup : MonoBehaviour
  {
    [SerializeField] private EntityBehaviour _entityView;
    [SerializeField] private PopupView _popupView;

    private void Awake()
    {
      GameEntity entity = CreateEntity.Empty()
          .AddPopupView(_popupView)
        
          .With(x=>x.isPopup = true)
          .With(x=>x.isInactive = true)
        ;
      
      _entityView.SetEntity(entity);
      _popupView.Hide();
    }
  }
}