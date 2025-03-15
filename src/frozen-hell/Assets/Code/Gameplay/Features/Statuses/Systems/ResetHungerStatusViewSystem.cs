using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
  public class ResetHungerStatusViewSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;
    private readonly List<GameEntity> _buffer = new (8);

    public ResetHungerStatusViewSystem(GameContext game)
    {
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.HungerView, 
          GameMatcher.ReadyToResetHunger, 
          GameMatcher.StarterCondition));
    }

    public void Execute()
    {
      foreach (GameEntity status in _statuses.GetEntities(_buffer))
      {
        status.HungerView.Refresh();
        status.isReadyToResetHunger = false;
      }
    }
  }
}