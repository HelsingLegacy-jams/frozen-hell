using Code.Infrastructure.Windowses;
using Entitas;

namespace Code.Gameplay.Features.Popups.Systems
{
  public class LoosePopupSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;
    private readonly IGroup<GameEntity> _popups;
    private readonly IWindowService _windowService;

    public LoosePopupSystem(GameContext game, IWindowService windowService)
    {
      _windowService = windowService;
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Loosed));
    }

    public void Execute()
    {
      foreach (GameEntity status in _statuses)
      {
        _windowService.ShowLoosePopup();
      }
    }
  }
}