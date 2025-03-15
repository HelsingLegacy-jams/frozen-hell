using UnityEngine;

namespace Code.Gameplay.Features.Popups.Behaviours
{
  public class WinPopupView : MonoBehaviour
  {
    public void Show() => 
      gameObject.SetActive(true);
  }
}