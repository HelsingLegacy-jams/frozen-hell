using Code.Gameplay.Features.Interactors.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Interactors
{
  public sealed class InteractorFeature : Feature
  {
    public InteractorFeature(ISystemFactory systems)
    {
      Add(systems.Create<BreachedInteractorsConsumingSystem>());
      
      Add(systems.Create<InteractorsCleanupSystem>());
    }
  }
}