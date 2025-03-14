using System.Collections.Generic;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.Systems
{
  public class MovingToInteractorPositionSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _movers;
    private readonly IPhysicsService _physics;
    private readonly ITimeService _time;
    private readonly List<GameEntity> _buffer = new (8);

    public MovingToInteractorPositionSystem(GameContext game, IPhysicsService physics, ITimeService time)
    {
      _physics = physics;
      _time = time;
      _movers = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Busy,
          GameMatcher.Speed,
          GameMatcher.Moving,
          GameMatcher.Transform,
          GameMatcher.Destination,
          GameMatcher.CharacterMover,
          GameMatcher.MovementAvailable));
    }

    public void Execute()
    {
      foreach (GameEntity mover in _movers.GetEntities(_buffer))
      {
        Vector2 position = new Vector2(mover.Transform.position.x, mover.Transform.position.z);
        Vector2 destination = new Vector2(mover.Destination.x, mover.Destination.z);
        
        if(Vector2.Distance(position, destination) > 1f)
          mover.CharacterMover
            .Move(mover.Destination - mover.Transform.position,
              mover.Speed, 
              _time.DeltaTime,
              _physics.Gravity);
        else
        {
          mover.isReadyToAction = true;
          mover.RemoveDestination();
          mover.isMoving = false;
        }
      }
    }
  }
}