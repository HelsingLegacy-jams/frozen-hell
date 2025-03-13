using Code.Gameplay.Common.Physics;
using Code.Gameplay.Features.Cameras.Service;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputInteractionProvidingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;
    private readonly IPhysicsService _physics;
    private readonly ICameraService _camera;

    public InputInteractionProvidingSystem(GameContext game, IPhysicsService physics, ICameraService camera)
    {
      _physics = physics;
      _camera = camera;
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input,
          GameMatcher.Interacted,
          GameMatcher.CursorPosition));
    }

    public void Execute()
    {
      foreach (GameEntity input in _inputs)
      {
        GameEntity interactor = _physics.Raycast(input.CursorPosition, _camera.Entity.MainCamera);
        interactor.isInteracted = true;
      }
    }
  }
}