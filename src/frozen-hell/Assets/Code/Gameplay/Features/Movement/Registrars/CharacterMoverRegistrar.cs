using Code.Gameplay.Features.Movement.Behaviours;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.Registrars
{
  public class CharacterMoverRegistrar : EntityComponentRegistrar
  {
    [SerializeField] private CharacterMover _mover;
    
    public override void Register() => 
      Entity.AddCharacterMover(_mover);

    public override void Unregister()
    {
      if(Entity.hasCharacterMover)
        Entity.RemoveCharacterMover();
    }
  }
}