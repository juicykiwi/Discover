using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Windlight.Utility.Singleton;

namespace Windlight.Scene
{
    public class SceneControl : SingletonBehaviour<SceneControl>
    {
        // Get current scene

        public string GetActiveScene()
        {
            return SceneManager.GetActiveScene().name;
        }

        // Load scene

        public void LoadScene( LoadSceneInfo loadSceneInfo )
        {
            SceneManager.LoadScene(loadSceneInfo.sceneName, loadSceneInfo.loadSceneMode);
        }

        public void LoadSceneAsync( LoadSceneInfo loadSceneInfo )
        {
            StartCoroutine(LoadSceneAsyncCoroutine(loadSceneInfo));
        }

        IEnumerator LoadSceneAsyncCoroutine( LoadSceneInfo loadSceneInfo )
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(loadSceneInfo.sceneName, loadSceneInfo.loadSceneMode);
            while (operation.isDone == false)
            {
                if (loadSceneInfo.onLoadProgress != null)
                {
                    loadSceneInfo.onLoadProgress(operation.progress);
                }

                yield return null;
            }
            yield return null;

            if (loadSceneInfo.onLoadComplete != null)
            {
                loadSceneInfo.onLoadComplete();
            }
        }

        // Unload Scene

        public void UnloadSceneAsync( UnloadSceneInfo unloadSceneInfo )
        {
            StartCoroutine(UnloadSceneAsyncCoroutine(unloadSceneInfo));
        }

        IEnumerator UnloadSceneAsyncCoroutine( UnloadSceneInfo unloadSceneInfo )
        {
            AsyncOperation operation = SceneManager.UnloadSceneAsync(unloadSceneInfo.sceneName);
            while (operation.isDone == false)
            {
                yield return null;
            }
            yield return null;

            if (unloadSceneInfo.onUnloadComplete != null)
            {
                unloadSceneInfo.onUnloadComplete();
            }
        }
    }
}

