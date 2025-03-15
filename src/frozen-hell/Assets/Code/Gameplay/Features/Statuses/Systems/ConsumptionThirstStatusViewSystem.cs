using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
  public class ConsumptionThirstStatusViewSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new(1);
    private readonly List<GameEntity> _buffer2 = new(8);

    public ConsumptionThirstStatusViewSystem(GameContext game)
    {
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.ThirstView));

      _survivors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Survivor,
          GameMatcher.ConsumeThirst));
    }

    public void Execute()
    {
      foreach (GameEntity survivor in _survivors.GetEntities(_buffer))
      foreach (GameEntity status in _statuses.GetEntities(_buffer2))
      {
        status.ThirstView.Updating(status.ThirstView.ViewCondition - survivor.ConsumeThirst / 100);

        survivor.RemoveConsumeThirst();
      }
    }
  }
}