﻿using System;
using System.Collections;
using Code.Infrastructure.Coroutines;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Infrastructure.Scenes
{
  public class SceneLoader : ISceneLoader
  {
    private readonly ICoroutineRunner _coroutineRunner;
    private ISceneLoader _sceneLoaderImplementation;

    public SceneLoader(ICoroutineRunner coroutineRunner)
    {
      _coroutineRunner = coroutineRunner;
    }

    public void Load(string nextScene, Action onLoaded = null)
    {
      _coroutineRunner.StartCoroutine(LoadScene(nextScene, onLoaded));
    }

    private IEnumerator LoadScene(string nextScene, Action onLoaded = null)
    {
      if (SceneManager.GetActiveScene().name == nextScene)
      {
        onLoaded?.Invoke();
        yield break;
      }

      AsyncOperation waitNextScene = SceneManager.LoadSceneAsync(nextScene);
      while (!waitNextScene.isDone)
        yield return null;
      
      onLoaded?.Invoke();
    }
  }
}