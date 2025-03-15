using UnityEngine;

namespace Code.Gameplay.Features.Survivor.Factory
{
  public interface ISurvivorFactory
  {
    GameEntity CreateSurvivor(Vector3 initialPoint);
  }
}