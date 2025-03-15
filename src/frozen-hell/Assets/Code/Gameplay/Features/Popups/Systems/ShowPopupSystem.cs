using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Popups.Systems
{
  public class ShowPopupSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _interactors;
    private readonly IGroup<GameEntity> _popups;
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new (1);

    public ShowPopupSystem(GameContext game)
    {
      _interactors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Interacted,
          GameMatcher.WorldPosition,
          GameMatcher.InteractorTypeId)
        .NoneOf(GameMatcher.Inactive));
      
      _popups = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Popup,
          GameMatcher.Inactive,
          GameMatcher.PopupView));
      
      _survivors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Survivor));
    }

    public void Execute()
    {
      foreach (GameEntity survivor in _survivors)
      foreach (GameEntity interactor in _interactors)
      foreach (GameEntity popup in _popups.GetEntities(_buffer))
      {
        if(survivor.isBusy)
          return;
        
        popup.PopupView.Show(interactor.WorldPosition, interactor.View, interactor.Title);
        popup.isInactive = false;
      }
    }
  }
}