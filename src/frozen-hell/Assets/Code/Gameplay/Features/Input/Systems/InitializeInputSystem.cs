using Code.Gameplay.Features.Input.Factory;
using Code.Gameplay.Features.Input.Provider;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InitializeInputSystem : IInitializeSystem
  {
    private readonly IInputProvider _provider;
    private readonly IInputFactory _factory;

    public InitializeInputSystem(IInputProvider provider, IInputFactory factory)
    {
      _provider = provider;
      _factory = factory;
    }

    public void Initialize()
    {
      _provider.SetInput(entity: _factory.CreateInput());
    }
  }
}