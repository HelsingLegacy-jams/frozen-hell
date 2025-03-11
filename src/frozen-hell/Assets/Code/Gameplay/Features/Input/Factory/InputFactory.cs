using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.AssetManagement;
using UnityEngine;

namespace Code.Gameplay.Features.Input.Factory
{
  public class InputFactory : IInputFactory
  {
    public GameEntity CreateInput()
    {
      return CreateEntity.Empty()
          .AddWorldPosition(Vector3.zero)
          .AddViewPath(AssetPath.Input)
          
          .With(x => x.isInput = true);
    }
  }
}