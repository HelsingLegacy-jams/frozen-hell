using Code.Gameplay.Features.Survivor.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Survivor
{
  [Game] public class Survivor : IComponent {}
  [Game] public class Busy : IComponent {}
  [Game] public class ReadyToAction : IComponent {}
  [Game] public class ReadyToCollections : IComponent {}
  
  [Game] public class SurvivorAnimatorComponent : IComponent { public SurvivorAnimator Value; }
  [Game] public class AnimationTypeIdComponent : IComponent { public AnimationTypeId Value; }
}