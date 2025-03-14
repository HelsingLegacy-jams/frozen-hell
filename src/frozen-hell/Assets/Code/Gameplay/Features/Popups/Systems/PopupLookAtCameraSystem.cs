using Code.Gameplay.Features.Cameras.Service;
using Entitas;

namespace Code.Gameplay.Features.Popups.Systems
{
  public class PopupLookAtCameraSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _popups;
    private readonly ICameraService _camera;

    public PopupLookAtCameraSystem(GameContext game, ICameraService camera)
    {
      _camera = camera;
      _popups = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Popup)
        .NoneOf(GameMatcher.Inactive));
    }

    public void Execute()
    {
      foreach (GameEntity popup in _popups)
      {
        popup.Transform.LookAt(popup.Transform.position - _camera.Entity.Transform.position);
      }
    }
  }
}