using Entitas;
using UnityEngine;

namespace Code.Gameplay.Common.Time.Systems
{
  public class CountdownSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _timers;
    private readonly ITimeService _time;

    public CountdownSystem(GameContext game, ITimeService time)
    {
      _time = time;
      _timers = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Time,
          GameMatcher.MaxTime,
          GameMatcher.Minutes,
          GameMatcher.Seconds));
    }

    public void Execute()
    {
      foreach (GameEntity timer in _timers)
      {
        timer.ReplaceTime(timer.Time - _time.DeltaTime);
        timer.ReplaceMinutes(Mathf.FloorToInt(timer.Time / 60));
        timer.ReplaceSeconds(Mathf.FloorToInt(timer.Time % 60));
      }
    }
  }
}