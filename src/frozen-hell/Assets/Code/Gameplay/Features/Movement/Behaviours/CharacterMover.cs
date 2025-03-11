using UnityEngine;

namespace Code.Gameplay.Features.Movement.Behaviours
{
  public class CharacterMover : MonoBehaviour, ICharacterMover
  {
    [SerializeField] private CharacterController _controller;

    public void Move(Vector3 direction, float speed, float deltaTime, Vector3 gravity)
    {
      Vector3 movementDirection = direction;
      movementDirection.Normalize();

      movementDirection += gravity;

      _controller.Move(movementDirection * speed * deltaTime);
    }
  }
}