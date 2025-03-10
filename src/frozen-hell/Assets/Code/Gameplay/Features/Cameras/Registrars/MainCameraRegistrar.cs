using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Registrars
{
  public class MainCameraRegistrar : EntityComponentRegistrar
  {
    [SerializeField] private Camera _camera;
    
    public override void Register() => 
      Entity.AddMainCamera(_camera);

    public override void Unregister()
    {
      if(Entity.hasMainCamera)
        Entity.RemoveMainCamera();
    }
  }
}