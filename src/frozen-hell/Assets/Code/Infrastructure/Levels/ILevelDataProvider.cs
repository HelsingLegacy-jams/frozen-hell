using UnityEngine;

namespace Code.Infrastructure.Levels
{
  public interface ILevelDataProvider
  {
    Transform InitialPoint { get; }
  }
}