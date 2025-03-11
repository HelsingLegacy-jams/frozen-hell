namespace Code.Gameplay.Features.Input.Provider
{
  public interface IInputProvider
  {
    GameEntity Entity { get; }
    void SetInput(GameEntity entity);
  }
}
