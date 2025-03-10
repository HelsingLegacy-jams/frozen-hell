using Code.Gameplay.Features.Cameras;
using Code.Gameplay.Features.Survivor;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View;

namespace Code.Gameplay.Features
{
  public sealed class GameFeature : Feature
  {
    public GameFeature(ISystemFactory systems)
    {
      Add(systems.Create<BindViewFeature>());
      
      Add(systems.Create<SurvivorFeature>());
      Add(systems.Create<CameraFeature>());
    }
  }
}