using System;
using System.Collections;
using System.Collections.Generic;

namespace Discover.Stage
{
    [Serializable]
    public class StageData
    {
        public int _index = 0;
        public string _description = "";

        public string _tiledMapName = "";

        public List<FieldInfo> _fieldInfoList = new List<FieldInfo>();


        public string GetDataName( bool includeExtension )
        {
            return StageData.GetDataName(_index, includeExtension);
        }

        public static string GetDataName( int stageIndex, bool includeExtension )
        {
            string dataName = string.Format("{0:D5}", stageIndex);

            if (includeExtension == true)
            {
                dataName = string.Format("{0}.{1}", dataName, GetDataExtension());
            }

            return dataName;
        }

        public static string GetDataExtension()
        {
            return "json";
        }
    }
}

