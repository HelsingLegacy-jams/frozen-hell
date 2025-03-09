using Zenject;

namespace Code.Infrastructure.EcsRunners.Factory
{
  public class RunnerFactory : IRunnerFactory
  {
    private readonly IInstantiator _instantiator;

    public RunnerFactory(IInstantiator instantiator)
    {
      _instantiator = instantiator;
    }

    public void CreateRunner() => 
      _instantiator.Instantiate<EcsRunner>();
  }
}