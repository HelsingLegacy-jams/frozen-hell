using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Features.Statuses.Behaviours
{
  public class StatusView : MonoBehaviour, IStatusView
  {
    [SerializeField] private Image _status;

    public float ViewCondition => _status.fillAmount;
    
    public void Updating(float condition) => 
      _status.fillAmount = condition;

    public void Refresh() => 
      _status.fillAmount = 0;
  }
}