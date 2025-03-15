using UnityEngine;

namespace Code.Infrastructure.Levels
{
  public class LevelDataProvider : ILevelDataBinder, ILevelDataProvider
  {
    private Transform _initPoint;
    public Transform InitialPoint => _initPoint;

    public void SetHeroInitialPoint(Transform initPoint) => 
      _initPoint = initPoint;
  }
}