using System.Collections.Generic;
using Code.Gameplay.Features.Statuses.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Statuses
{
  public class InitializeStatusView : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;
    private readonly List<GameEntity> _buffer = new (8);

    public InitializeStatusView(GameContext game)
    {
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.NotInitialized, 
          GameMatcher.StatusViews, 
          GameMatcher.StarterCondition));
    }

    public void Execute()
    {
      foreach (GameEntity status in _statuses.GetEntities(_buffer))
      foreach (IStatusView view in status.StatusViews)
      {
        view.Updating(status.StarterCondition);
        status.isNotInitialized = false;
      }
    }
  }
}