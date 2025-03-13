using Entitas;

namespace Code.Gameplay.Features.Popups.Systems
{
  public class ShowPopupSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _interactors;
    private readonly IGroup<GameEntity> _popups;

    public ShowPopupSystem(GameContext game)
    {
      _interactors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Interacted,
          GameMatcher.WorldPosition,
          GameMatcher.InteractorTypeId));
      
      _popups = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Popup,
          GameMatcher.Inactive,
          GameMatcher.PopupView));
    }

    public void Execute()
    {
      foreach (GameEntity interactor in _interactors)
      foreach (GameEntity popup in _popups)
      {
        popup.PopupView.Show(interactor.WorldPosition, interactor.View, interactor.InteractorTypeId);
        popup.isInactive = false;
      }
    }
  }
}