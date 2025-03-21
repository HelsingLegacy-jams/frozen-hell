using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Code.Infrastructure.Loading
{
    public class StartFromInitialScene : MonoBehaviour
    {
#if UNITY_EDITOR
        private const int EntrySceneIndex = 0;

        private void Awake()
        {
            if(ProjectContext.HasInstance || SceneManager.GetActiveScene().buildIndex == EntrySceneIndex)
                return;

            foreach (GameObject root in SceneManager.GetActiveScene().GetRootGameObjects()) 
                root.SetActive(false);
            
            SceneManager.LoadScene(EntrySceneIndex);
        }

#endif
    }
}
