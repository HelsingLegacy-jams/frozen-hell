using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Systems
{
  public class CameraFollowFeature : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _cameras;
    private readonly IGroup<GameEntity> _survivor;

    public CameraFollowFeature(GameContext game)
    {
      _cameras = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.FocusedCamera,
          GameMatcher.MainCamera,
          GameMatcher.Transform,
          GameMatcher.Offset,
          GameMatcher.Distance,
          GameMatcher.RotationAngleX));
      
      _survivor = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.FocusedCamera,
          GameMatcher.MainCamera,
          GameMatcher.Transform,
          GameMatcher.Offset,
          GameMatcher.Distance,
          GameMatcher.RotationAngleX));
    }

    public void Execute()
    {
      foreach (GameEntity camera in _cameras) 
      // foreach (GameEntity survivor in _survivor)
      {
        Quaternion rotation = Quaternion.Euler(camera.RotationAngleX, 0f, 0f);
        Vector3 position = rotation * new Vector3(0f, 0f, -camera.Distance) + PositionOffset(camera, camera);
        
        camera.Transform.rotation = rotation;
        camera.Transform.position = position;
      }

    }

    private Vector3 PositionOffset(GameEntity target, GameEntity camera) => 
      new(target.Transform.position.x, camera.Offset, target.Transform.position.z);
  }
}