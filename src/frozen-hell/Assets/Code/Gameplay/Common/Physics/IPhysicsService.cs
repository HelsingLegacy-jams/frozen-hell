﻿using Code.Gameplay.Common.Collisions;
using UnityEngine;

namespace Code.Gameplay.Common.Physics
{
  public interface IPhysicsService
  {
    Vector3 RaycastPoint(Vector2 point, Camera camera, float distance = 20f,
      CollisionLayer layer = CollisionLayer.Walkable);

    GameEntity Raycast(Vector2 point, Camera camera, float distance = 30f, 
      CollisionLayer layer = CollisionLayer.Interactable);

    Vector3 Gravity { get; }
    GameEntity SphereCast(Vector3 position, float radius, int layerMask);
  }
}