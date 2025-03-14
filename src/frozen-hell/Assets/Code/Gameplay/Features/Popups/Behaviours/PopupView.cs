using Code.Common.Extensions;
using Code.Infrastructure.View;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Features.Popups.Behaviours
{
  public class PopupView : MonoBehaviour
  {
    [SerializeField] private EntityBehaviour _popupView;
    
    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private Button BreachButton;
    [SerializeField] private Button ConsumeButton;
    private IEntityView _interactorView;

    private void Awake()
    {
      BreachButton.onClick.AddListener(Breaching);
      ConsumeButton.onClick.AddListener(Consuming);
    }

    private void Breaching()
    {
      // _interactorView.Entity.isBreached = true;
      Hide();
    }

    private void Consuming()
    {
      // _interactorView.Entity.isConsumed = true;
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