using System;
using System.Collections.Generic;
using Code.Infrastructure.GameStates.Factory;
using Code.Infrastructure.GameStates.States;

namespace Code.Infrastructure.GameStates.Machine
{
  public class GameStateMachine : IGameStateMachine
  {
    private readonly Dictionary<Type, IState> _states;

    public GameStateMachine(IStateFactory factory)
    {
      _states = new Dictionary<Type, IState>
        {
          [typeof(BootstrapState)] = factory.Create<BootstrapState>(this),
          [typeof(LoadLevelState)] = factory.Create<LoadLevelState>(this),
          [typeof(GameLoopState)] = factory.Create<GameLoopState>(),
        }
        ;

    }

    public void Enter<TState>() where TState : IState
    {
      IState state = _states[typeof(TState)];
      state.Enter();
    }
  }
}