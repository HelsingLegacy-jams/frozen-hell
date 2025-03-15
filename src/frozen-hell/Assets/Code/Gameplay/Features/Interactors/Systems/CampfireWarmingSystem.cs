using Code.Common.Extensions;
using Code.Gameplay.Common.Collisions;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Interactors.Systems
{
  public class CampfireWarmingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _campfires;
    private readonly IPhysicsService _physics;
    private readonly ITimeService _time;

    public CampfireWarmingSystem(GameContext game, IPhysicsService physics, ITimeService time)
    {
      _physics = physics;
      _time = time;
      _campfires = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.InteractorTypeId)
        .NoneOf(GameMatcher.Consumable));
    }

    public void Execute()
    {
      foreach (GameEntity campfire in _campfires)
      {
        GameEntity survivorInRange = _physics.SphereCast(campfire.WorldPosition, 5f, CollisionLayer.Survivor.AsMask());

        survivorInRange?.AddConsumeCold(3.5f * _time.DeltaTime);
      }
    }
  }
}