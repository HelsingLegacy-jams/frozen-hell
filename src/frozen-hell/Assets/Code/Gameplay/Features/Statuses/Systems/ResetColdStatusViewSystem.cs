using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
  public class ResetColdStatusViewSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;
    private readonly List<GameEntity> _buffer = new (8);

    public ResetColdStatusViewSystem(GameContext game)
    {
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.ColdView, 
          GameMatcher.ReadyToResetCold, 
          GameMatcher.StarterCondition));
    }

    public void Execute()
    {
      foreach (GameEntity status in _statuses.GetEntities(_buffer))
      {
        status.ColdView.Refresh();
        status.isReadyToResetCold = false;
      }
    }
  }
}