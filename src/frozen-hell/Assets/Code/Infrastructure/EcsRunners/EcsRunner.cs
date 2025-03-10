using Code.Gameplay.Features;
using Code.Infrastructure.Systems;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.EcsRunners
{
  public class EcsRunner : MonoBehaviour
  {
    private GameFeature _gameFeature;
    private ISystemFactory _systems;

    [Inject]
    public void Construct(ISystemFactory systems) =>
      _systems = systems;

    private void Start()
    {
      _gameFeature = _systems.Create<GameFeature>();
      _gameFeature.Initialize();
    }

    private void Update()
    {
      _gameFeature.Execute();
      _gameFeature.Cleanup();
    }

    private void OnDestroy() => 
      _gameFeature.TearDown();
  }
}