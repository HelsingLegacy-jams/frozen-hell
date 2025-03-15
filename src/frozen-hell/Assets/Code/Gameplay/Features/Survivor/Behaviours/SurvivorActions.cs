using Code.Gameplay.Features.Survivor.Provider;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Survivor.Behaviours
{
  public class SurvivorActions : MonoBehaviour
  {
    private ISurvivorProvider _survivor;

    [Inject]
    public void Construct(ISurvivorProvider survivor)
    {
      _survivor = survivor;
    }

    public void Collected()
    {
      _survivor.Entity.isBusy = false;
      _survivor.Entity.isReadyToAction = false;

      _survivor.Entity.isReadyToCollections = true;
      _survivor.Entity.AddAnimationTypeId(AnimationTypeId.Idle);
    }
    
    public void Breached()
    {
      _survivor.Entity.AddAnimationTypeId(AnimationTypeId.Collect);
    }
  }
}