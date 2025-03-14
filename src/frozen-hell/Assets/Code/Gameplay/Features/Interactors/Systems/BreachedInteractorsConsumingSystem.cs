using Entitas;

namespace Code.Gameplay.Features.Interactors.Systems
{
  public class BreachedInteractorsConsumingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _interactors;
    private readonly IGroup<GameEntity> _survivors;

    public BreachedInteractorsConsumingSystem(GameContext game)
    {
      _interactors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Breached,
          GameMatcher.Consumable,
          GameMatcher.InteractorTypeId));
      
      _survivors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Survivor));
    }

    public void Execute()
    {
      foreach (GameEntity interactor in _interactors)
      foreach (GameEntity survivor in _survivors)
      {
        switch (interactor.InteractorTypeId)
        {
          case InteractorTypeId.BlueBerries:
            survivor.AddConsumeHunger(40f);
            break;
          case InteractorTypeId.RedBerries:
            survivor.AddConsumeHunger(20f);
            survivor.AddConsumeThirst(20f);
            break;
          case InteractorTypeId.Mushrooms:
            survivor.AddConsumeHunger(50f);
            survivor.AddConsumeCold(10f);
            survivor.AddConsumeThirst(-20f);
            break;
        }
      }
    }
  }
}