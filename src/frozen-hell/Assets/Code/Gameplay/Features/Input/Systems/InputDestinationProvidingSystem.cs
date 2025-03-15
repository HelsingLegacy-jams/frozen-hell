using System.Collections.Generic;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Features.Cameras.Service;
using Code.Gameplay.Features.Survivor;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputDestinationProvidingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new (1);
    
    private readonly IPhysicsService _physics;
    private readonly ICameraService _camera;

    public InputDestinationProvidingSystem(GameContext game, IPhysicsService physics, ICameraService camera)
    {
      _physics = physics;
      _camera = camera;
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input,
          GameMatcher.CursorPosition,
          GameMatcher.MovementProvided));
      
      _survivors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Survivor)
        .NoneOf(GameMatcher.Busy));
    }

    public void Execute()
    {
      foreach (GameEntity input in _inputs)
      foreach (GameEntity survivor in _survivors.GetEntities(_buffer))
      {
        Vector3 point = _physics.RaycastPoint(input.CursorPosition, _camera.Entity.MainCamera);
        if (point == Vector3.zero)
          continue;
        
        survivor.AddDestination(point);
        survivor.isMoving = input.isMovementProvided;
        survivor.isBusy = true;
        survivor.AddAnimationTypeId(AnimationTypeId.Move);
      }
    }
  }
}