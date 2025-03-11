using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.Systems
{
  public class TurnAlongDirectionSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _turners;

    public TurnAlongDirectionSystem(GameContext game)
    {
      _turners = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Moving,
          GameMatcher.Transform,
          GameMatcher.Destination));
    }

    public void Execute()
    {
      foreach (GameEntity turner in _turners)
      {
        Vector3 destination = new Vector3(turner.Destination.x, 0f, turner.Destination.z);
        Vector3 position = new Vector3(turner.Transform.position.x, 0f, turner.Transform.position.z);
        
        turner.Transform.rotation = Quaternion.LookRotation(destination - position);
      }
    }
  }
}