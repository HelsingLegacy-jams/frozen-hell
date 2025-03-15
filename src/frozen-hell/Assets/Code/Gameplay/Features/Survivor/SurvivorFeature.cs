using Code.Gameplay.Features.Survivor.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Survivor
{
  public sealed class SurvivorFeature : Feature
  {
    public SurvivorFeature(ISystemFactory systems)
    {
      Add(systems.Create<InitializeSurvivorSystem>());
      
      Add(systems.Create<SurvivorAnimationProvidingSystem>());
    }
  }
}