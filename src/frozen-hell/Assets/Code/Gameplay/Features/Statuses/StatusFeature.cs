using Code.Gameplay.Features.Statuses.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Statuses
{
  public sealed class StatusFeature : Feature
  {
    public StatusFeature(ISystemFactory systems)
    {
      Add(systems.Create<ResetHungerStatusViewSystem>());
      Add(systems.Create<ResetThirstStatusViewSystem>());
      Add(systems.Create<ResetColdStatusViewSystem>());
      
      Add(systems.Create<StatusUpdateSystem>());
    }
  }
}