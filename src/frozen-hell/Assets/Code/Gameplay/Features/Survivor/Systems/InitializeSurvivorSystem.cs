using Code.Gameplay.Features.Survivor.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Survivor.Systems
{
  public class InitializeSurvivorSystem : IInitializeSystem
  {
    private readonly ISurvivorFactory _factory;

    public InitializeSurvivorSystem(ISurvivorFactory factory)
    {
      _factory = factory;
    }

    public void Initialize() => 
      _factory.CreateSurvivor(Vector3.zero);
  }
}