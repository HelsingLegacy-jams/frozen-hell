using Code.Common.Extensions;
using Code.Gameplay.Common.Collisions;
using UnityEngine;

namespace Code.Gameplay.Common.Physics
{
  public class PhysicsService : IPhysicsService
  {
    private readonly ICollisionRegistry _collisions;
    private readonly RaycastHit[] Hit = new RaycastHit[8];

    public Vector3 Gravity => UnityEngine.Physics.gravity;

    public PhysicsService(ICollisionRegistry collisions) => 
      _collisions = collisions;

    public Vector3 RaycastPoint(Vector2 point, Camera camera, float distance = 20, CollisionLayer layer = CollisionLayer.Walkable)
    {
      Ray ray = camera.ScreenPointToRay(point);
      
      return UnityEngine.Physics.Raycast(ray, out RaycastHit hit, distance, layer.AsMask())
        ? hit.point
        : Vector3.zero;
    }

    public GameEntity Raycast(Vector2 point, Camera camera, float distance = 30,
      CollisionLayer layer = CollisionLayer.Interactable)
    {
      Ray ray = camera.ScreenPointToRay(point);

      int hitCount = UnityEngine.Physics.RaycastNonAlloc(ray, Hit, distance, layer.AsMask());

      for (int i = 0; i < hitCount; i++)
      {
        RaycastHit hit = Hit[i];
        if(hit.collider == null)
          continue;

        GameEntity entity = _collisions.GetEntity<GameEntity>(hit.collider.GetInstanceID());
        if (entity == null)
          continue;
        return entity;
      }
      
      return null;
    }
  }
}