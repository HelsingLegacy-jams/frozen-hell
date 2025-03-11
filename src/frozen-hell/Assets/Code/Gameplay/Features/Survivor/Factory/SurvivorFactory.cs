using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.AssetManagement;
using UnityEngine;

namespace Code.Gameplay.Features.Survivor.Factory
{
  public class SurvivorFactory : ISurvivorFactory
  {
    public GameEntity CreateSurvivor(Vector3 initialPosition)
    {
      return CreateEntity.Empty()
        .AddWorldPosition(initialPosition)
        .AddViewPath(AssetPath.Survivor)
        
        .AddSpeed(5f)

        .With(x => x.isSurvivor = true)
        .With(x => x.isMovementAvailable = true);
    }
  }
}