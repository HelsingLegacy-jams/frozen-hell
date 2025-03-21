﻿using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
  public class AssetProvider : IAssetProvider
  {
    public T LoadAsset<T>(string path) where T : Component => 
      Resources.Load<T>(path);

    public GameObject LoadAsset(string path) => 
      Resources.Load<GameObject>(path);
  }
}