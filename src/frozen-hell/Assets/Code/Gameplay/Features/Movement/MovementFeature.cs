using Code.Gameplay.Features.Movement.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Movement
{
  public sealed class MovementFeature : Feature
  {
    public MovementFeature(ISystemFactory systems)
    {
      Add(systems.Create<MovingToDestinationPointSystem>());
      Add(systems.Create<MovingToInteractorPositionSystem>());
      Add(systems.Create<TurnAlongDirectionSystem>());
    }
  }
}