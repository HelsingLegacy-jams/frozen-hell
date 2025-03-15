using Code.Gameplay.Features.Popups.Behaviours;

namespace Code.Infrastructure.Windowses
{
  public class WindowService : IWindowService
  {
    private LoosePopupView _loosePopup;
    private WinPopupView _winPopup;

    public void BindLoosePopup(LoosePopupView loosePopup) => 
      _loosePopup = loosePopup;

    public void BindWinPopup(WinPopupView winPopup) => 
      _winPopup = winPopup;

    public void ShowWinPopup() => 
      _winPopup.Show();

    public void ShowLoosePopup() => 
      _loosePopup.Show();
  }
}