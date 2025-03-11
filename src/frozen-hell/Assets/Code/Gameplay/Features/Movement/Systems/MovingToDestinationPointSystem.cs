using Code.Gameplay.Common.Physics;
using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.Systems
{
  public class MovingToDestinationPointSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _movers;
    private readonly IPhysicsService _physics;
    private readonly ITimeService _time;

    public MovingToDestinationPointSystem(GameContext game, IPhysicsService physics, ITimeService time)
    {
      _physics = physics;
      _time = time;
      _movers = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Speed,
          GameMatcher.Moving,
          GameMatcher.Transform,
          GameMatcher.Destination,
          GameMatcher.CharacterMover,
          GameMatcher.MovementAvailable)
        .NoneOf(GameMatcher.Busy));
    }

    public void Execute()
    {
      foreach (GameEntity mover in _movers)
      {
        if(Vector3.Distance(mover.Transform.position, mover.Destination) > 0.05f)
          mover.CharacterMover
            .Move(mover.Destination - mover.Transform.position,
              mover.Speed, 
              _time.DeltaTime,
              _physics.Gravity);
        else
        {
          mover.RemoveDestination();
          mover.isBusy = false;
          mover.isMoving = false;
        }
      }
    }
  }
}