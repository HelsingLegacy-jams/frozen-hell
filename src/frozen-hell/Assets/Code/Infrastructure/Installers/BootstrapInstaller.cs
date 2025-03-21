﻿using Code.Gameplay.Common.Collisions;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Cameras.Factory;
using Code.Gameplay.Features.Cameras.Service;
using Code.Gameplay.Features.Input.Factory;
using Code.Gameplay.Features.Input.Service;
using Code.Gameplay.Features.Survivor.Factory;
using Code.Gameplay.Features.Survivor.Provider;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Coroutines;
using Code.Infrastructure.EcsRunners.Factory;
using Code.Infrastructure.GameStates.Factory;
using Code.Infrastructure.GameStates.Machine;
using Code.Infrastructure.GameStates.States;
using Code.Infrastructure.Levels;
using Code.Infrastructure.Scenes;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View.Factory;
using Code.Infrastructure.Windowses;
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

      Container.Bind<IInputService>().To<InputService>().AsSingle();
      Container.Bind<IInputFactory>().To<InputFactory>().AsSingle();
      
      Container.Bind<ICameraService>().To<CameraService>().AsSingle();
      Container.Bind<ICameraFactory>().To<CameraFactory>().AsSingle();
      
      Container.Bind<ISurvivorFactory>().To<SurvivorFactory>().AsSingle();
      Container.Bind<ISurvivorProvider>().To<SurvivorProvider>().AsSingle();
    }

    private void BindContexts()
    {
      Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();
      Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
    }

    private void BindInfrastructureServices()
    {
      Container.BindInterfacesTo<LevelDataProvider>().AsSingle();
      Container.Bind<IWindowService>().To<WindowService>().AsSingle();
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