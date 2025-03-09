using Code.Infrastructure.GameStates.States;

namespace Code.Infrastructure.GameStates
{
  public interface IGameStateMachine
  {
    void Enter<TState>() where TState : IState;
  }
}