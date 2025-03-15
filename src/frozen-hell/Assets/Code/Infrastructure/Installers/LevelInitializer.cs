using Code.Gameplay.Features.Popups.Behaviours;
using Code.Infrastructure.Levels;
using Code.Infrastructure.Windowses;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class LevelInitializer : MonoBehaviour, IInitializable
  {
    [SerializeField] private Transform _initPoint;
    [SerializeField] private LoosePopupView _loosePopup;
    [SerializeField] private WinPopupView _winPopup;
    
    private ILevelDataBinder _levelDataBinder;
    private IWindowService _windowses;

    [Inject]
    public void Construct(ILevelDataBinder levelDataBinder, IWindowService windowses)
    {
      _levelDataBinder = levelDataBinder;
      _windowses = windowses;
    }

    public void Initialize()
    {
      _levelDataBinder.SetHeroInitialPoint(_initPoint);
      _windowses.BindLoosePopup(_loosePopup);
      _windowses.BindWinPopup(_winPopup);
    }
  }
}