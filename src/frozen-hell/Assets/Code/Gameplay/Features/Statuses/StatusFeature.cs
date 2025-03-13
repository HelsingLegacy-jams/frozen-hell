using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Statuses
{
  public sealed class StatusFeature : Feature
  {
    public StatusFeature(ISystemFactory systems)
    {
      Add(systems.Create<InitializeStatusView>());
      Add(systems.Create<StatusUpdateSystem>());
    }
  }
}