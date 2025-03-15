using Code.Gameplay.Features.Popups.Behaviours;

namespace Code.Infrastructure.Windowses
{
  public interface IWindowService
  {
    void ShowLoosePopup();
    void BindLoosePopup(LoosePopupView loosePopup);
    void ShowWinPopup();
    void BindWinPopup(WinPopupView loosePopup);
  }
}