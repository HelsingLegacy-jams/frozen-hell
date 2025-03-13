using Code.Gameplay.Features.Popups.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Popups
{
  [Game] public class Popup : IComponent {}
  [Game] public class PopupViewComponent : IComponent { public PopupView Value; }
  [Game] public class InteractorTypeIdComponent : IComponent { public InteractorTypeId Value; }
}