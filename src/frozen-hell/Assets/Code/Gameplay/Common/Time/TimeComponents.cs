using Code.Gameplay.Common.Time.Behaviours;
using Entitas;

namespace Code.Gameplay.Common.Time
{
  [Game] public class Time : IComponent { public float Value; }
  [Game] public class MaxTime : IComponent { public float Value; }
  
  [Game] public class Minutes : IComponent { public int Value; }
  [Game] public class Seconds : IComponent { public int Value; }
  
  [Game] public class RescueCountdownComponent : IComponent { public RescueCountdown Value; }
}