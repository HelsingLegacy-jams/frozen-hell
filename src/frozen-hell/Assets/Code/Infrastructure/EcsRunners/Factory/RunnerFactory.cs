using Code.Infrastructure.AssetManagement;
using Zenject;

namespace Code.Infrastructure.EcsRunners.Factory
{
  public class RunnerFactory : IRunnerFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assets;

    public RunnerFactory(IInstantiator instantiator, IAssetProvider assets)
    {
      _instantiator = instantiator;
      _assets = assets;
    }

    public void CreateRunner()
    {
      EcsRunner runner = _assets.LoadAsset<EcsRunner>(AssetPath.EcsRunner);
      _instantiator.InstantiatePrefabForComponent<EcsRunner>(runner);
    }
  }
}