using Code.Gameplay.Features.Cameras;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features
{
  public sealed class SurvivorFeature : Feature
  {
    public SurvivorFeature(ISystemFactory systems)
    {
      Add(systems.Create<CameraFeature>());
    }
  }
}