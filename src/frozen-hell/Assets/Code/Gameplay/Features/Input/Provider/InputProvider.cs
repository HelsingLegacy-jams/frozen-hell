namespace Code.Gameplay.Features.Input.Provider
{
  public class InputProvider : IInputProvider
  {
    private GameEntity _input;
    public GameEntity Input => _input;
    
    public void SetInput(GameEntity input) => 
      _input = input;
  }
}