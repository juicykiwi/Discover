using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windlight.Data;

namespace Discover.Stage
{
    public class StageDataControl
    {
        public StageData Load( int stageIndex )
        {
            FileInfo fileInfo = new FileInfo();
            fileInfo.path = "Stage";
            fileInfo.name = StageData.GetDataName(stageIndex, false);
            fileInfo.extension = StageData.GetDataExtension();

            StageData loadData = DataControl.LoadJson<StageData>(fileInfo);
            return loadData;
        }

        public void Save( StageData data )
        {
            FileInfo fileInfo = new FileInfo();
            fileInfo.path = StageDataPath();
            fileInfo.name = data.GetDataName(false);
            fileInfo.extension = StageData.GetDataExtension();

            DataControl.SaveJson<StageData>(data, fileInfo);
        }

        private string StageDataPath()
        {
            return Application.dataPath + "/Resources/Stage";
        }
    }
}