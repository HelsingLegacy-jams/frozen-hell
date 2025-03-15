using Code.Common.Extensions;
using Code.Gameplay.Features.Survivor;
using Code.Gameplay.Features.Survivor.Provider;
using Code.Infrastructure.View;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Features.Popups.Behaviours
{
  public class PopupView : MonoBehaviour
  {
    [SerializeField] private EntityBehaviour _popupView;
    
    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private Button BreachButton;
    [SerializeField] private Button ConsumeButton;
    
    private IEntityView _interactorView;
    private ISurvivorProvider _survivor;

    [Inject]
    public void Construct(ISurvivorProvider survivor) => 
      _survivor = survivor;

    private void Awake()
    {
      BreachButton.onClick.AddListener(Breaching);
      ConsumeButton.onClick.AddListener(Consuming);
    }

    private void Breaching()
    {
      _survivor.Entity.AddDestination(_interactorView.Entity.Transform.position);
      _survivor.Entity.AddAnimationTypeId(AnimationTypeId.Breach);
      _survivor.Entity.isMovingToInteract = true;
      _survivor.Entity.isBusy = true;
      _survivor.Entity.isMoving = true;

      _interactorView.Entity.isBreached = true;
      Hide();
    }

    private void Consuming()
    {
      _survivor.Entity.AddDestination(_interactorView.Entity.Transform.position);
      _survivor.Entity.AddAnimationTypeId(AnimationTypeId.Collect);
      _survivor.Entity.isBusy = true;
      _survivor.Entity.isMoving = true;
      _survivor.Entity.isMovingToInteract = true;

      _interactorView.Entity.isConsumed = true;
      Hide();
    }


    public void Show(Vector3 targetLocation, IEntityView interactorView, string title)
    {
      _interactorView = interactorView;
      
      _title.text = title;
      transform.position = targetLocation.AddY();
      gameObject.SetActive(true);
    }

    public void Hide()
    {
      _popupView.Entity.isInactive = true;
      gameObject.SetActive(false);
    }
  }
}