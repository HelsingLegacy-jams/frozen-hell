namespace Code.Gameplay.Features.Cameras.Service
{
  public class CameraService : ICameraService
  {
    private GameEntity _entity;
    public GameEntity Entity => _entity;
    
    public void SetCamera(GameEntity entity) => 
      _entity = entity;
  }
}