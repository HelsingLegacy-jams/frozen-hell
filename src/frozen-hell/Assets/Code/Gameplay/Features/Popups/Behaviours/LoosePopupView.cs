using UnityEngine;

namespace Code.Gameplay.Features.Popups.Behaviours
{
  public class LoosePopupView : MonoBehaviour
  {
    public void Show() => 
      gameObject.SetActive(true);
  }
}