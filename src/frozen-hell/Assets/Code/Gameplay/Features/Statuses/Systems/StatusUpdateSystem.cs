using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Statuses.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
  public class StatusUpdateSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;
    private readonly ITimeService _time;
    private readonly List<GameEntity> _buffer = new (8);

    public StatusUpdateSystem(GameContext game, ITimeService time)
    {
      _time = time;
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Increment,
          GameMatcher.StatusViews)
        .NoneOf(GameMatcher.Inactive));
    }

    public void Execute()
    {
      foreach (GameEntity status in _statuses.GetEntities(_buffer))
      foreach (IStatusView view in status.StatusViews)
      {
        view.Updating(view.ViewCondition + status.Increment * _time.DeltaTime / 100);

        if (view.ViewCondition >= status.DeadlyCondition)
        {
          status.isLoosed = true;
          _time.StopTime();
          status.isInactive = true;
        }
      }
    }
  }
}