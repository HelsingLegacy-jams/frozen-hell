using Code.Infrastructure.GameStates.Machine;

namespace Code.Infrastructure.GameStates.States
{
  public class LoadLevelState : IState
  {
    private readonly IGameStateMachine _stateMachine;

    public LoadLevelState(IGameStateMachine stateMachine)
    {
      _stateMachine = stateMachine;
    }

    public void Enter()
    {
      _stateMachine.Enter<GameLoopState>();
    }
  }
}