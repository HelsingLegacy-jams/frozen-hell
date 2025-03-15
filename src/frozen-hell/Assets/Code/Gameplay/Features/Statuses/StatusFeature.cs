using Code.Gameplay.Features.Statuses.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Statuses
{
  public sealed class StatusFeature : Feature
  {
    public StatusFeature(ISystemFactory systems)
    {
      Add(systems.Create<StatusResetSystem>());

      Add(systems.Create<ConsumptionHungerStatusViewSystem>());
      Add(systems.Create<ConsumptionThirstStatusViewSystem>());
      Add(systems.Create<ConsumptionColdStatusViewSystem>());

      Add(systems.Create<StatusUpdateSystem>());

      Add(systems.Create<CleanupStatusSystem>());
    }
  }
}