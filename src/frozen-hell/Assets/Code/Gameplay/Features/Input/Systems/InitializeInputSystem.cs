using Code.Gameplay.Features.Input.Factory;
using Code.Gameplay.Features.Input.Service;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InitializeInputSystem : IInitializeSystem
  {
    private readonly IInputService _service;
    private readonly IInputFactory _factory;

    public InitializeInputSystem(IInputService service, IInputFactory factory)
    {
      _service = service;
      _factory = factory;
    }

    public void Initialize()
    {
      _service.SetInput(entity: _factory.CreateInput());
    }
  }
}