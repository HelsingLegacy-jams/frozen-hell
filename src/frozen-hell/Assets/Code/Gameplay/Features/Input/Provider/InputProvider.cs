using Code.Gameplay.Features.Input.Service;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Code.Gameplay.Features.Input.Provider
{
  public class InputProvider : MonoBehaviour
  {
    private const float Epsilon = 0.001f;
    
    private IInputService _input;
    private Vector2 _lastPosition;

    [Inject]
    public void Construct(IInputService input) => 
      _input = input;

    public void OnMove(InputValue value)
    {
      Vector2 cursorPosition = value.Get<Vector2>();

      if (Vector2.Distance(cursorPosition, Vector2.zero) > Epsilon)
        _lastPosition = cursorPosition;

      _input.Entity.ReplaceCursorPosition(_lastPosition);
      _input.Entity.isMovementProvided = true;
      
      Debug.Log(_lastPosition);
    }
  }
}