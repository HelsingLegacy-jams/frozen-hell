namespace Code.Gameplay.Features.Input.Service
{
  public interface IInputService
  {
    GameEntity Entity { get; }
    void SetInput(GameEntity entity);
  }
}
