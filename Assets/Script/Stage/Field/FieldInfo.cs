using System;
using System.Collections;
using System.Collections.Generic;

namespace Discover.Stage
{
    [Serializable]
    public class FieldInfo
    {
        public FieldType fieldType { get; set; }

        public List<ZoneInfo> _zoneInfoList = new List<ZoneInfo>();
    }
}

