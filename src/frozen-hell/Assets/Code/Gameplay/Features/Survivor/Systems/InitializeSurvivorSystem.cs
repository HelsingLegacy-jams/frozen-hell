using Code.Gameplay.Features.Survivor.Factory;
using Code.Gameplay.Features.Survivor.Provider;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Survivor.Systems
{
  public class InitializeSurvivorSystem : IInitializeSystem
  {
    private readonly ISurvivorFactory _factory;
    private readonly ISurvivorProvider _survivor;

    public InitializeSurvivorSystem(ISurvivorFactory factory, ISurvivorProvider survivor)
    {
      _factory = factory;
      _survivor = survivor;
    }

    public void Initialize() => 
      _survivor.SetSurvivor(_factory.CreateSurvivor(Vector3.zero));
  }
}