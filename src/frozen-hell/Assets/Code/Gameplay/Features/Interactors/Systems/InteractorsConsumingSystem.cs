using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Interactors.Systems
{
  public class InteractorsConsumingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _interactors;
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new (1);
    private readonly List<GameEntity> _buffer2 = new (1);

    public InteractorsConsumingSystem(GameContext game)
    {
      _interactors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Consumed,
          GameMatcher.Consumable,
          GameMatcher.InteractorTypeId)
        .NoneOf(GameMatcher.Breached));
      
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
            survivor.AddConsumeHunger(-15f);
            survivor.AddConsumeThirst(15f);
            break;
          case InteractorTypeId.RedBerries:
            survivor.AddConsumeHunger(35f);
            survivor.AddConsumeThirst(-5f);
            break;
          case InteractorTypeId.YellowMushroom:
            survivor.AddConsumeHunger(-10f);
            survivor.AddConsumeThirst(25f);
            break;
          case InteractorTypeId.BrownMushroom:
            survivor.AddConsumeHunger(5f);
            survivor.AddConsumeThirst(20f);
            survivor.AddConsumeCold(-10f);
            break;
        }
        survivor.isReadyToCollections = false;
        interactor.isConsumed = false;
        interactor.isInactive = true;
      }
    }
  }
}