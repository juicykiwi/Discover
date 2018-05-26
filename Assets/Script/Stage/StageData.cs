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

        public List<FieldInfo> _fieldInfoList = new List<FieldInfo>();


        // Init data

        public void InitData()
        {
            foreach (FieldInfo eachFiledInfo in _fieldInfoList)
            {
                eachFiledInfo.InitData();
            }
        }
    }
}

