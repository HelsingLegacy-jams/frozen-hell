using System.Collections.Generic;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Features.Cameras.Service;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputInteractionProvidingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;
    private readonly IGroup<GameEntity> _popups;
    private readonly List<GameEntity> _buffer = new (1);

    public InputInteractionProvidingSystem(GameContext game)
    {
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input,
          GameMatcher.Interacted,
          GameMatcher.CursorPosition));
      
      _popups = game.GetGroup(GameMatcher
        .AllOf(
          // GameMatcher.Popup,
          GameMatcher.Interacted,
          GameMatcher.CursorPosition));
      
    }

    public void Execute()
    {
      foreach (GameEntity input in _inputs)
      foreach (GameEntity popup in _popups.GetEntities(_buffer))
      {
        
      }
    }
  }
}