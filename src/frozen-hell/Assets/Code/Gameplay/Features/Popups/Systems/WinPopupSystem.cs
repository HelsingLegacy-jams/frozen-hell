using Code.Infrastructure.Windowses;
using Entitas;

namespace Code.Gameplay.Features.Popups.Systems
{
  public class WinPopupSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _timers;
    private readonly IGroup<GameEntity> _popups;
    private readonly IWindowService _windowService;

    public WinPopupSystem(GameContext game, IWindowService windowService)
    {
      _windowService = windowService;
      _timers = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Win));
    }

    public void Execute()
    {
      foreach (GameEntity timer in _timers)
      {
        _windowService.ShowWinPopup();
      }
    }
  }
}