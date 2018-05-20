using System;
using System.Collections;
using UnityEngine;
using Windlight.Scene;
using Windlight.Data;

namespace Discover.Stage
{
    public class StageScene : SceneBase
    {
        [SerializeField]
        StageBase _stage = null;


        void Start()
        {
            StartCoroutine(InitStageCoroutine());
        }

        IEnumerator InitStageCoroutine()
        {
            InitStageBase();
            yield return null;

            while (_stage.isLoadedStage == false)
            {
                yield return null;
            }
        }

        void InitStageBase()
        {
            FileInfo fileInfo = new FileInfo();
            fileInfo.path = "Prefab/Stage";
            fileInfo.fileName = "StageBase";

            _stage = DataControl.LoadDataInResources<StageBase>(fileInfo);
            _stage.transform.SetParent(transform);

            StageInitInfo stageInitInfo = new StageInitInfo();
            stageInitInfo.StageIndex = 0;
            _stage.LoadStage(stageInitInfo);
        }
    }
}

