namespace Code.Gameplay.Features.Input.Provider
{
  public class InputProvider : IInputProvider
  {
    private GameEntity _entity;
    public GameEntity Entity => _entity;
    
    public void SetInput(GameEntity entity) => 
      _entity = entity;
  }
}