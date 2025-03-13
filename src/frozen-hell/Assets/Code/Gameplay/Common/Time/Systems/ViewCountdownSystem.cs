using Entitas;

namespace Code.Gameplay.Common.Time.Systems
{
  public class ViewCountdownSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _timers;

    public ViewCountdownSystem(GameContext game)
    {
      _timers = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Minutes, 
          GameMatcher.Seconds, 
          GameMatcher.RescueCountdown));
    }

    public void Execute()
    {
      foreach (GameEntity timer in _timers)
      {
        timer.RescueCountdown.UpdateTimer(timer.Minutes, timer.Seconds);
      }
    }
  }
}