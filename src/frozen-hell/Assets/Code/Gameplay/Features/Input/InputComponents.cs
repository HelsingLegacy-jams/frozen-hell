using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Input
{
  [Game] public class Input : IComponent {}
  [Game] public class MovementProvided : IComponent {}
  
  [Game] public class CursorPosition : IComponent { public Vector2 Value; }
}