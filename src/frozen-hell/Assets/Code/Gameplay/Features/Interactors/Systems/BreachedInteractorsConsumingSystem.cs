using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Interactors.Systems
{
  public class BreachedInteractorsConsumingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _interactors;
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new (1);
    private readonly List<GameEntity> _buffer2 = new (1);

    public BreachedInteractorsConsumingSystem(GameContext game)
    {
      _interactors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Breached,
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
      foreach (GameEntity interactor in _interactors.GetEntities(_buffer2))
      foreach (GameEntity survivor in _survivors.GetEntities(_buffer))
      {
        switch (interactor.InteractorTypeId)
        {
          case InteractorTypeId.BlueBerries:
            survivor.AddConsumeHunger(30f);
            survivor.AddConsumeCold(5f);
            break;
          case InteractorTypeId.RedBerries:
            survivor.AddConsumeHunger(25f);
            survivor.AddConsumeThirst(15f);
            break;
          case InteractorTypeId.YellowMushroom:
            survivor.AddConsumeHunger(25f);
            survivor.AddConsumeThirst(-15f);
            survivor.AddConsumeCold(5f);
            break;
          case InteractorTypeId.BrownMushroom:
            survivor.AddConsumeThirst(15f);
            survivor.AddConsumeCold(5f);
            break;
        }
        survivor.isReadyToCollections = false;
        interactor.isBreached = false;
        interactor.isConsumed = false;
        interactor.isInactive = true;
      }
    }
  }
}