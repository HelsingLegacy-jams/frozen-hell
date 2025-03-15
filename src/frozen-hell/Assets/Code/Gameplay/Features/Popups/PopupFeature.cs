using Code.Gameplay.Features.Popups.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Popups
{
  public sealed class PopupFeature : Feature
  {
    public PopupFeature(ISystemFactory systems)
    {
      Add(systems.Create<WinPopupSystem>());
      Add(systems.Create<LoosePopupSystem>());
      Add(systems.Create<ShowPopupSystem>());
      Add(systems.Create<PopupLookAtCameraSystem>());
    }
  }
}