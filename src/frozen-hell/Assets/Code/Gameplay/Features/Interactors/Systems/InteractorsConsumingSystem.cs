using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Interactors.Systems
{
  public class InteractorsConsumingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _interactors;
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new (1);

    public InteractorsConsumingSystem(GameContext game)
    {
      _interactors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Consumed,
          GameMatcher.Consumable,
          GameMatcher.InteractorTypeId));
      
      _survivors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Survivor,
          GameMatcher.ReadyToCollections
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
            survivor.AddConsumeHunger(-10f);
            survivor.AddConsumeThirst(-10f);
            break;
          case InteractorTypeId.RedBerries:
            survivor.AddConsumeHunger(10f);
            break;
          case InteractorTypeId.Mushrooms:
            survivor.AddConsumeHunger(-10f);
            survivor.AddConsumeThirst(20f);
            break;
        }
      }
    }
  }
}