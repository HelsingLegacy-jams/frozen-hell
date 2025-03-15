using Code.Infrastructure.Levels;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class LevelInitializer : MonoBehaviour, IInitializable
  {
    [SerializeField] private Transform _initPoint;
    private ILevelDataBinder _levelDataBinder;

    [Inject]
    public void Construct(ILevelDataBinder levelDataBinder) => 
      _levelDataBinder = levelDataBinder;

    public void Initialize() => 
      _levelDataBinder.SetHeroInitialPoint(_initPoint);
  }
}