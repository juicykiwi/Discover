using System;
using UnityEngine.SceneManagement;

namespace Windlight.Scene
{
    public class LoadSceneInfo
    {
        public string sceneName { get; set; }
        public LoadSceneMode loadSceneMode { get; set; }
        public Action<float> onLoadProgress { get; set; }
        public Action onLoadComplete { get; set; }
    }
}