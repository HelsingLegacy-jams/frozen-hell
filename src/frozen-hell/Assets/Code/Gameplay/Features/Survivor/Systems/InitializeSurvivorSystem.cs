using Code.Gameplay.Features.Survivor.Factory;
using Code.Gameplay.Features.Survivor.Provider;
using Code.Infrastructure.Levels;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Survivor.Systems
{
  public class InitializeSurvivorSystem : IInitializeSystem
  {
    private readonly ISurvivorFactory _factory;
    private readonly ISurvivorProvider _survivor;
    private readonly ILevelDataProvider _level;

    public InitializeSurvivorSystem(ISurvivorFactory factory, ISurvivorProvider survivor, ILevelDataProvider level)
    {
      _factory = factory;
      _survivor = survivor;
      _level = level;
    }

    public void Initialize() => 
      _survivor.SetSurvivor(_factory.CreateSurvivor(_level.InitialPoint.position));
  }
}