using Code.Gameplay.Common.Collisions;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Cameras.Factory;
using Code.Gameplay.Features.Input.Factory;
using Code.Gameplay.Features.Survivor.Factory;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Coroutines;
using Code.Infrastructure.EcsRunners.Factory;
using Code.Infrastructure.GameStates.Factory;
using Code.Infrastructure.GameStates.Machine;
using Code.Infrastructure.GameStates.States;
using Code.Infrastructure.Scenes;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View.Factory;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public void Initialize()
    {
      Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
    }

    public override void InstallBindings()
    {
      BindInstaller();
      BindContexts();
      BindInfrastructureServices();
      BindGameStates();
      BindGameplayServices();
    }

    private void BindGameplayServices()
    {
      Container.Bind<ICollisionRegistry>().To<CollisionRegistry>().AsSingle();
      Container.Bind<IPhysicsService>().To<PhysicsService>().AsSingle();
      Container.Bind<ITimeService>().To<TimeService>().AsSingle();
      
      Container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();

      Container.Bind<IRunnerFactory>().To<RunnerFactory>().AsSingle();
      
      Container.Bind<IInputFactory>().To<InputFactory>().AsSingle();
      Container.Bind<ICameraFactory>().To<CameraFactory>().AsSingle();
      Container.Bind<ISurvivorFactory>().To<SurvivorFactory>().AsSingle();
    }

    private void BindContexts()
    {
      Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();
      Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
    }

    private void BindInfrastructureServices()
    {
      Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
      Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
      
      Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
    }

    private void BindGameStates()
    {
      Container.Bind<IStateFactory>().To<StateFactory>().AsSingle();
      Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
    }

    private void BindInstaller()
    {
      Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();
    }
  }
}