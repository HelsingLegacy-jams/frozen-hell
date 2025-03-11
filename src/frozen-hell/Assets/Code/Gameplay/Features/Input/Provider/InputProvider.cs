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

    [Inject]
    public void Construct(IInputService input) => 
      _input = input;

    public void OnMove(InputValue value)
    {
      Vector2 cursorPosition = value.Get<Vector2>();

      if (Vector2.Distance(cursorPosition, Vector2.zero) < Epsilon)
        return;

      _input.Entity.ReplaceCursorPosition(cursorPosition);
      _input.Entity.isMovementProvided = true;
      
      Debug.Log(cursorPosition);
    }
  }
}