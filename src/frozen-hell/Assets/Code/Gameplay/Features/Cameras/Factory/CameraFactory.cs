using Code.Common.Entity;
using Code.Common.Extensions;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Factory
{
  public class CameraFactory : ICameraFactory
  {
    public GameEntity CreateCamera()
    {
      return CreateEntity.Empty()
          .AddWorldPosition(new Vector3(0f, 2f, -10f))
          .AddViewPath("Camera/MainCamera")
          
          .AddOffset(0.5f)
          .AddDistance(10f)
          .AddRotationAngleX(55f)
        
          .With(x=>x.isFocusedCamera = true)
        ;
    }
  }
}