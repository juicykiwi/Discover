using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Discover.Stage
{
    public class StageSerializeInfo
    {
        public const string DataPath = "Data/Stage";
        public const string DataExtension = "json";

        public static string GetDataName( int stageIndex, bool includeExtension )
        {
            string dataName = string.Format("{0:D5}", stageIndex);

            if (includeExtension == true)
            {
                dataName = string.Format("{0}.{1}", dataName, StageSerializeInfo.DataExtension);
            }

            return dataName;
        }

        public static string DataSavePath()
        {
            return Application.dataPath + "/Resources/Data/Stage";
        }
    }

    public class StagePrefabInfo
    {
        public const string Path = "Prefab/Stage";
        public const string BaseDataName = "StageBase";
    }
}