using Code.Gameplay.Features.Input.Service;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Code.Gameplay.Features.Input.Provider
{
  public class InputProvider : MonoBehaviour
  {
    private IInputService _input;
    private bool _isMovementProvided;
    private bool _isInteractionProvided;

    [Inject]
    public void Construct(IInputService input) => 
      _input = input;

    public void OnMove(InputValue value)
    {
      _isMovementProvided = !_isMovementProvided;
      
      if(!_isMovementProvided)
        return;
      
      _input.Entity.ReplaceCursorPosition(value.Get<Vector2>());
      _input.Entity.isMovementProvided = true;
    }

    public void OnInteract(InputValue value)
    {
      _isInteractionProvided = !_isInteractionProvided;
      
      if(!_isInteractionProvided)
        return;
      
      _input.Entity.ReplaceCursorPosition(value.Get<Vector2>());
      _input.Entity.isInteracted = true;
    }
  }
}