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
        turner.Transform.rotation = Quaternion.LookRotation(turner.Destination);
      }
    }
  }
}