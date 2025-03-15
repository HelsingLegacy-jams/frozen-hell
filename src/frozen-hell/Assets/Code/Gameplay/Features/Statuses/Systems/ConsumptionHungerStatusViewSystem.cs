using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
  public class ConsumptionHungerStatusViewSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new(1);
    private readonly List<GameEntity> _buffer2 = new(8);

    public ConsumptionHungerStatusViewSystem(GameContext game)
    {
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.HungerView));

      _survivors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Survivor,
          GameMatcher.ConsumeHunger));
    }

    public void Execute()
    {
      foreach (GameEntity survivor in _survivors.GetEntities(_buffer))
      foreach (GameEntity status in _statuses.GetEntities(_buffer2))
      {
        status.HungerView.Updating(status.HungerView.ViewCondition - survivor.ConsumeHunger / 100);

        survivor.RemoveConsumeHunger();
      }
    }
  }
}