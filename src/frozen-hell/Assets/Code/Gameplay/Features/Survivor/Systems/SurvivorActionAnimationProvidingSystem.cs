using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Survivor.Systems
{
  public class SurvivorActionAnimationProvidingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new (1);

    public SurvivorActionAnimationProvidingSystem(GameContext game)
    {
      _survivors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Survivor, 
          GameMatcher.ReadyToAction, 
          GameMatcher.AnimationTypeId, 
          GameMatcher.SurvivorAnimator));
    }

    public void Execute()
    {
      foreach (GameEntity survivor in _survivors.GetEntities(_buffer))
      {
        switch (survivor.AnimationTypeId)
        {
          case AnimationTypeId.Breach:
            survivor.SurvivorAnimator.PlayBreaching();
            break;
          case AnimationTypeId.Collect:
            survivor.SurvivorAnimator.PlayCollecting();
            break;
        }

        survivor.RemoveAnimationTypeId();
      }
    }
  }
}