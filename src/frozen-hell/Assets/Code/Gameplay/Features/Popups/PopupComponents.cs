using Code.Gameplay.Features.Popups.Behaviours;
using Code.Gameplay.Features.Survivor;
using Entitas;

namespace Code.Gameplay.Features.Popups
{
  [Game] public class Popup : IComponent {}
  [Game] public class Inactive : IComponent {}
  [Game] public class PopupViewComponent : IComponent { public PopupView Value; }
  [Game] public class PromiseAnimationId : IComponent { public AnimationTypeId Value; }
}