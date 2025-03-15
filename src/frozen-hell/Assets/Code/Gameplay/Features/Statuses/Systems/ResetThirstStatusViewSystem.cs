using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
  public class ResetThirstStatusViewSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;
    private readonly List<GameEntity> _buffer = new (8);

    public ResetThirstStatusViewSystem(GameContext game)
    {
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.ThirstView, 
          GameMatcher.ReadyToResetThirst, 
          GameMatcher.StarterCondition));
    }

    public void Execute()
    {
      foreach (GameEntity status in _statuses.GetEntities(_buffer))
      {
        status.ThirstView.Refresh();
        status.isReadyToResetThirst = false;
      }
    }
  }
}