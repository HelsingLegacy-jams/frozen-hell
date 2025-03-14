using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Interactors.Systems
{
  public class InteractorsCleanupSystem : ICleanupSystem
  {
    private readonly IGroup<GameEntity> _interactors;
    private readonly List<GameEntity> _buffer = new(1);

    public InteractorsCleanupSystem(GameContext game)
    {
      _interactors = game.GetGroup(GameMatcher
        .AllOf(GameMatcher.InteractorTypeId));
    }

    public void Cleanup()
    {
      foreach (GameEntity interactor in _interactors.GetEntities(_buffer))
      {
        interactor.isInteracted = false;
      }
    }
  }
}