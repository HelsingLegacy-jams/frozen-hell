namespace Code.Gameplay.Features.Cameras.Service
{
  public interface ICameraService
  {
    GameEntity Entity { get; }
    void SetCamera(GameEntity entity);
  }
}