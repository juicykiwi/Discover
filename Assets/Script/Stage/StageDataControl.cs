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
            fileInfo.path = StageSerializeInfo.DataPath;
            fileInfo.fileName = StageSerializeInfo.GetDataName(stageIndex, false);
            fileInfo.extension = StageSerializeInfo.DataExtension;

            StageData loadData = DataControl.LoadJson<StageData>(fileInfo);
            return loadData;
        }

        public void Save( StageData data )
        {
            FileInfo fileInfo = new FileInfo();
            fileInfo.path = StageSerializeInfo.DataSavePath();
            fileInfo.fileName = StageSerializeInfo.GetDataName(data._index, false);
            fileInfo.extension = StageSerializeInfo.DataExtension;

            DataControl.SaveJson<StageData>(data, fileInfo);
        }
    }
}