using Code.Gameplay.Features.Cameras.Factory;
using Code.Gameplay.Features.Cameras.Service;
using Entitas;

namespace Code.Gameplay.Features.Cameras.Systems
{
  public class InitializeCameraSystem : IInitializeSystem
  {
    private readonly ICameraFactory _factory;
    private readonly ICameraService _camera;

    public InitializeCameraSystem(ICameraFactory factory, ICameraService camera)
    {
      _factory = factory;
      _camera = camera;
    }

    public void Initialize() => 
      _camera.SetCamera(_factory.CreateCamera());
  }
}