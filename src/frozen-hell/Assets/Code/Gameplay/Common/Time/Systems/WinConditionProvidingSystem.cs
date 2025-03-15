using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Common.Time.Systems
{
  public class WinConditionProvidingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _timers;
    private readonly ITimeService _time;
    private readonly List<GameEntity> _buffer = new (1);

    public WinConditionProvidingSystem(GameContext game, ITimeService time)
    {
      _time = time;
      _timers = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Minutes, 
          GameMatcher.Seconds)
        .NoneOf(GameMatcher.Inactive));
    }

    public void Execute()
    {
      foreach (GameEntity timer in _timers.GetEntities(_buffer))
      {
        if (timer.Minutes <= 0 && timer.Seconds <= 0)
        {
          timer.isWin = true;
          _time.StopTime();
          timer.isInactive = true;
        }
      }
    }
  }
}