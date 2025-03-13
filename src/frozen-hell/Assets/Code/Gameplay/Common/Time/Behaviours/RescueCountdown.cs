using TMPro;
using UnityEngine;

namespace Code.Gameplay.Common.Time.Behaviours
{
  public class RescueCountdown : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _rescueCountdown;

    public void UpdateTimer(int minutes, int seconds)
    {
        _rescueCountdown.text = string.Format($"{minutes:00}:{seconds:00}");
    }
  }
}