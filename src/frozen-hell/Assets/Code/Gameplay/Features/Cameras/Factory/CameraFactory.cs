using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.AssetManagement;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Factory
{
  public class CameraFactory : ICameraFactory
  {
    public GameEntity CreateCamera()
    {
      return CreateEntity.Empty()
          .AddWorldPosition(Vector3.zero)
          .AddViewPath(AssetPath.MainCamera)
          
          .AddOffset(0.5f)
          .AddDistance(10f)
          .AddRotationAngleX(55f)
        
          .With(x=>x.isFocusedCamera = true)
        ;
    }
  }
}