using Code.Gameplay.Features.Statuses.Behaviours;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
  public class StatusResetSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;

    public StatusResetSystem(GameContext game)
    {
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.ReadyToCleanup,
          GameMatcher.StatusViews));
    }

    public void Execute()
    {
      foreach (GameEntity status in _statuses)
      foreach (IStatusView view in status.StatusViews)
      {
        view.Refresh();
      }
    }
  }
}