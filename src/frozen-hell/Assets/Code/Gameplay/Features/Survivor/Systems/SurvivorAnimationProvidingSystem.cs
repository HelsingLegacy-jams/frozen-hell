using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Survivor.Systems
{
  public class SurvivorAnimationProvidingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _survivors;
    private readonly List<GameEntity> _buffer = new (1);

    public SurvivorAnimationProvidingSystem(GameContext game)
    {
      _survivors = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Survivor, 
          GameMatcher.AnimationTypeId, 
          GameMatcher.SurvivorAnimator));
    }

    public void Execute()
    {
      foreach (GameEntity survivor in _survivors.GetEntities(_buffer))
      {
        switch (survivor.AnimationTypeId)
        {
          case AnimationTypeId.Idle:
            survivor.SurvivorAnimator.ResetAbility();
            survivor.SurvivorAnimator.PlayIdle();
            break;
          case AnimationTypeId.Move:
            survivor.SurvivorAnimator.PlayMove();
            break;
        }

        survivor.RemoveAnimationTypeId();
      }
    }
  }
}