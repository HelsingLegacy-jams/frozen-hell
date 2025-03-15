using Code.Gameplay.Features.Survivor.Behaviours;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Survivor.Registrars
{
  public class SurvivorAnimatorRegistrar : EntityComponentRegistrar
  {
    [SerializeField] private SurvivorAnimator _animator;

    public override void Register() => 
      Entity.AddSurvivorAnimator(_animator);

    public override void Unregister()
    {
      if (Entity.hasSurvivorAnimator)
        Entity.RemoveSurvivorAnimator();
    }
  }
}