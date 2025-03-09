using UnityEngine;

namespace Code.Infrastructure.View.Registrars
{
  public class EntityDependant : MonoBehaviour
  {
    [SerializeField] private EntityBehaviour _entityView;
    
    public GameEntity Entity => _entityView != null ? _entityView.Entity : null;

    private void Awake()
    {
      if(!_entityView)
        _entityView = GetComponent<EntityBehaviour>();
    }
  }
}