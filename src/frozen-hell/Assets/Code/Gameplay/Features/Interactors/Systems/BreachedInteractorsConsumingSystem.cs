using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Interactors.Systems
{
  public class BreachedInteractorsConsumingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _interactors;
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new (1);

    public BreachedInteractorsConsumingSystem(GameContext game)
    {
      _interactors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Breached,
          GameMatcher.Consumable,
          GameMatcher.InteractorTypeId));
      
      _survivors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.ReadyToAction,
          GameMatcher.Survivor
          ));
    }

    public void Execute()
    {
      foreach (GameEntity interactor in _interactors)
      foreach (GameEntity survivor in _survivors.GetEntities(_buffer))
      {
        switch (interactor.InteractorTypeId)
        {
          case InteractorTypeId.BlueBerries:
            survivor.AddConsumeHunger(20f);
            break;
          case InteractorTypeId.RedBerries:
            survivor.AddConsumeHunger(5f);
            survivor.AddConsumeThirst(20f);
            break;
          case InteractorTypeId.Mushrooms:
            survivor.AddConsumeHunger(25f);
            survivor.AddConsumeCold(5f);
            survivor.AddConsumeThirst(-10f);
            break;
        }
      }
    }
  }
}