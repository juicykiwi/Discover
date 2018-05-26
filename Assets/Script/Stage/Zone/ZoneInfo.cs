using System;
using System.Collections;
using System.Collections.Generic;

namespace Discover.Stage
{
    [Serializable]
    public class ZoneInfo
    {
        public List<BlockInfo> _blockInfoList = new List<BlockInfo>();
        public List<CoverInfo> _coverInfoList = new List<CoverInfo>();


        // Init data

        public void InitData()
        {
        }
    }
}

