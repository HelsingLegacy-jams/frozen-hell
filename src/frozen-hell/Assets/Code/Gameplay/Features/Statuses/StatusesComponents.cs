using System.Collections.Generic;
using Code.Gameplay.Features.Statuses.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Statuses
{
  [Game] public class Increment : IComponent { public float Value; }
  [Game] public class DeadlyCondition : IComponent { public float Value; }
  [Game] public class StarterCondition : IComponent { public float Value; }

  [Game] public class StatusViews : IComponent { public List<StatusView> Value; }
  
  [Game] public class HungerView : IComponent { public IStatusView Value; }
  [Game] public class ThirstView : IComponent { public IStatusView Value; }
  [Game] public class ColdView : IComponent { public IStatusView Value; }
  
  [Game] public class ReadyToResetHunger : IComponent {}
  [Game] public class ReadyToResetThirst : IComponent {}
  [Game] public class ReadyToResetCold : IComponent {}
}