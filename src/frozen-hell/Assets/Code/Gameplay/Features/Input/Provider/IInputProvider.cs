namespace Code.Gameplay.Features.Input.Provider
{
  public interface IInputProvider
  {
    GameEntity Input { get; }
    void SetInput(GameEntity input);
  }
}
