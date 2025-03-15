using Entitas;

namespace Code.Gameplay.Features.Interactors
{
  [Game] public class Breached : IComponent {}
  [Game] public class Consumed : IComponent {}
  [Game] public class Consumable : IComponent {}
  
  [Game] public class ReadyToCleanup : IComponent {}
  
  [Game] public class Title : IComponent { public string Value; }
  
  [Game] public class ConsumeHunger : IComponent { public float Value; }
  [Game] public class ConsumeThirst : IComponent { public float Value; }
  [Game] public class ConsumeCold : IComponent { public float Value; }
  
  [Game] public class InteractorTypeIdComponent : IComponent { public InteractorTypeId Value; }
}