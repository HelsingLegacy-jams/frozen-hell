using Code.Gameplay.Common.Time.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Common.Time
{
  public sealed class TimerFeature : Feature
  {
    public TimerFeature(ISystemFactory systems)
    {
      Add(systems.Create<CountdownSystem>());
      
      Add(systems.Create<ViewCountdownSystem>());
    }
  }
}