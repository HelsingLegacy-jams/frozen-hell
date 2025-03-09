using Code.Infrastructure.EcsRunners.Factory;
using Code.Infrastructure.GameStates.Machine;

namespace Code.Infrastructure.GameStates.States
{
  public class LoadLevelState : IState
  {
    private readonly IGameStateMachine _stateMachine;
    private readonly IRunnerFactory _ecs;

    public LoadLevelState(IGameStateMachine stateMachine, IRunnerFactory ecs)
    {
      _stateMachine = stateMachine;
      _ecs = ecs;
    }

    public void Enter()
    {
      _ecs.CreateRunner();
      
      _stateMachine.Enter<GameLoopState>();
    }
  }
}