﻿using Code.Infrastructure.Coroutines;
using Code.Infrastructure.GameStates.Factory;
using Code.Infrastructure.GameStates.Machine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public void Initialize()
    {
      
    }

    public override void InstallBindings()
    {
      BindGameStates();
      BindInstaller();
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