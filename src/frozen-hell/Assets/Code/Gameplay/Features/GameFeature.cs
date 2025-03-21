﻿using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Cameras;
using Code.Gameplay.Features.Input;
using Code.Gameplay.Features.Interactors;
using Code.Gameplay.Features.Movement;
using Code.Gameplay.Features.Popups;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Survivor;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View;

namespace Code.Gameplay.Features
{
  public sealed class GameFeature : Feature
  {
    public GameFeature(ISystemFactory systems)
    {
      Add(systems.Create<BindViewFeature>());
      
      Add(systems.Create<InputFeature>());
      Add(systems.Create<PopupFeature>());
      Add(systems.Create<InteractorFeature>());
      
      Add(systems.Create<SurvivorFeature>());
      Add(systems.Create<MovementFeature>());
      
      Add(systems.Create<CameraFeature>());
      
      Add(systems.Create<StatusFeature>());
      Add(systems.Create<TimerFeature>());
    }
  }
}