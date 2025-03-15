using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class SceneInitializationInstaller : MonoInstaller
  {
    [SerializeField] private MonoBehaviour _initializer;

    public override void InstallBindings()
    {
      Container.BindInterfacesTo(_initializer.GetType()).FromInstance(_initializer).AsSingle();
    }
  }
}