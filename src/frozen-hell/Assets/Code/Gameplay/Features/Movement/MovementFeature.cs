using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Movement
{
  public sealed class MovementFeature : Feature
  {
    public MovementFeature(ISystemFactory systems)
    {
      Add(systems.Create<MovingToDestinationPointSystem>());
    }
  }
}