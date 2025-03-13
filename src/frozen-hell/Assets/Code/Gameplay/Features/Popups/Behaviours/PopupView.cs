using Code.Common.Extensions;
using Code.Infrastructure.View;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Features.Popups.Behaviours
{
  public class PopupView : MonoBehaviour
  {
    [SerializeField] private Button BreachButton;
    [SerializeField] private Button ConsumeButton;
    
    private IEntityView _interactorView;
    private InteractorTypeId _typeId;

    private void Start()
    {
      BreachButton.onClick.AddListener(Breaching);
      ConsumeButton.onClick.AddListener(Consuming);
    }

    private void Breaching()
    {
      // _interactorView.Entity.isActive = false;
    }

    private void Consuming()
    {
      // _interactorView.Entity.isActive = false;
      
    }


    public void Show(Vector3 targetLocation, IEntityView interactorView, InteractorTypeId TypeId)
    {
      _interactorView = interactorView;
      _typeId = TypeId;
      
      transform.position = targetLocation.AddY();
      gameObject.SetActive(true);
    }
  }
}