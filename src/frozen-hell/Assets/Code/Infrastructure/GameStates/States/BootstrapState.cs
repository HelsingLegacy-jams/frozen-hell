using Code.Infrastructure.GameStates.Machine;
using Code.Infrastructure.Scenes;

namespace Code.Infrastructure.GameStates.States
{
  public class BootstrapState : IState
  {
    private const string Main = "Main";
    private readonly IGameStateMachine _stateMachine;
    private readonly ISceneLoader _sceneLoader;

    public BootstrapState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
    {
      _stateMachine = stateMachine;
      _sceneLoader = sceneLoader;
    }

    public void Enter()
    {
      _sceneLoader.Load(nextScene: Main, MoveToNextState);
    }

    private void MoveToNextState()
    {
      _stateMachine.Enter<LoadLevelState>();
    }
  }
}