using System;

namespace Windlight.Scene
{
    public class UnloadSceneInfo
    {
        public string sceneName { get; set; }
        public Action onUnloadComplete { get; set; }
    }
}

