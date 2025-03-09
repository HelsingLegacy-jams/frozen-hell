using Code.Infrastructure.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View.Factory
{
  public class EntityViewFactory : IEntityViewFactory
  {
    private readonly IAssetProvider _assetProvider;
    private readonly IInstantiator _instantiator;

    public EntityViewFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }

    public EntityBehaviour CreateViewForEntity(GameEntity entity)
    {
      EntityBehaviour viewPrefab = _assetProvider.LoadAsset<EntityBehaviour>(entity.ViewPath);
      EntityBehaviour view = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
        viewPrefab,
        entity.WorldPosition,
        Quaternion.identity, 
        parentTransform: null);
      
      view.SetEntity(entity);
      return view;
    }

    public EntityBehaviour CreateViewForEntityFromPrefab(GameEntity entity)
    {
      EntityBehaviour view = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
        entity.ViewPrefab,
        entity.WorldPosition,
        Quaternion.identity, 
        parentTransform: null);
      
      view.SetEntity(entity);
      return view;
    }
  }
}