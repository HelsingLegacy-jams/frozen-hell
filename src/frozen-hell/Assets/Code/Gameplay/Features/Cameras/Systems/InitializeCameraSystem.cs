using Code.Gameplay.Features.Cameras.Factory;
using Entitas;

namespace Code.Gameplay.Features.Cameras.Systems
{
  public class InitializeCameraSystem : IInitializeSystem
  {
    private readonly ICameraFactory _factory;

    public InitializeCameraSystem(ICameraFactory factory) => 
      _factory = factory;

    public void Initialize() => 
      _factory.CreateCamera();
  }
}