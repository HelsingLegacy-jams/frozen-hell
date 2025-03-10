using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
  public interface IAssetProvider
  {
    T LoadAsset<T>(string path) where T : Component;
    GameObject LoadAsset(string path);
  }
}