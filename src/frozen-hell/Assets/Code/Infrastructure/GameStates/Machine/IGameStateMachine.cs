using Code.Infrastructure.GameStates.States;

namespace Code.Infrastructure.GameStates.Machine
{
  public interface IGameStateMachine
  {
    void Enter<TState>() where TState : IState;
  }
}