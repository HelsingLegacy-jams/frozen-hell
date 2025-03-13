using System.Collections.Generic;
using Code.Gameplay.Features.Statuses.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Statuses
{
  [Game] public class Loosed : IComponent {}
  [Game] public class NotInitialized : IComponent {}

  [Game] public class Increment : IComponent { public float Value; }
  [Game] public class DeadlyCondition : IComponent { public float Value; }
  [Game] public class StarterCondition : IComponent { public float Value; }

  [Game] public class StatusViews : IComponent { public List<IStatusView> Value; }
}