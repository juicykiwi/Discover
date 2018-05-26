using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windlight.TiledMap;

namespace Discover.Stage
{
    [Serializable]
    public class FieldInfo
    {
        public FieldType _fieldType = FieldType.EarthContinent;

        public string _tiledMapDataName = "";

        [SerializeField]
        protected TiledMapData _tiledMapData = null;
        public TiledMapData tiledMapData { get { return _tiledMapData; } }

        public List<ZoneInfo> _zoneInfoList = new List<ZoneInfo>();


        // Init data

        public void InitData()
        {
            _tiledMapData = TiledMapImport.ImportTileMapData(_tiledMapDataName);

            foreach (ZoneInfo eachZoneInfo in _zoneInfoList)
            {
                eachZoneInfo.InitData();
            }
        }
    }
}

