using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
  public class CleanupStatusSystem : ICleanupSystem
  {
    private readonly IGroup<GameEntity> _statuses;
    private readonly List<GameEntity> _buffer = new(8);

    public CleanupStatusSystem(GameContext game)
    {
      _statuses = game.GetGroup(GameMatcher.AllOf(GameMatcher.StatusViews, GameMatcher.ReadyToCleanup));
    }

    public void Cleanup()
    {
      foreach (GameEntity status in _statuses.GetEntities(_buffer))
      {
        status.isReadyToCleanup = false;
      }
    }
  }
}