using System;
using UnityEngine;
using Windlight.Scene;
using Windlight.Data;

namespace Discover.Stage
{
    public class StageScene : SceneBase
    {
        [SerializeField]
        StageBase _stage = null;

        void Awake()
        {
            FileInfo fileInfo = new FileInfo();
            fileInfo.path = "Prefab/Stage";
            fileInfo.fileName = "StageBase";

            _stage = DataControl.LoadDataInResources<StageBase>(fileInfo);
            _stage.transform.SetParent(transform);
        }
    }
}

