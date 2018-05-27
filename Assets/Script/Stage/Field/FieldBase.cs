using System.Collections.Generic;
using UnityEngine;
using Windlight.Data;
using Windlight.TiledMap;
using Windlight.UnityObject;

namespace Discover.Stage
{
    public class FieldBase : MonoBehaviour
    {
        protected int _width = 0;
        protected int _height = 0;

        protected List<ZoneBase> _zoneList = new List<ZoneBase>();


        // Init field

        public void InitField( FieldInfo fieldInfo )
        {
            TiledMapData tiledMapData = fieldInfo.tiledMapData;
            _width = tiledMapData.width;
            _height = tiledMapData.height;

            CreateZone(tiledMapData);
        }

        public void CreateZone( TiledMapData mapData )
        {
            int zoneCount = mapData.width * mapData.height;
            for (int zoneIndex = 0; zoneIndex < zoneCount; ++zoneIndex)
            {
                ZoneBase zone = ZoneFactory.CreateZone();
                UnityObjectHelper.SetParent(gameObject, zone.gameObject, true);

                int posX = GetZonePosX(zoneIndex);
                int posY = GetZonePosY(zoneIndex);
                zone.transform.localPosition = new Vector3(posX, posY);
                zone.gameObject.name = string.Format(ZoneObjectInfo.ZoneNameTemplate, posX, posY);

                _zoneList.Add(zone);
            }
        }

        protected int GetZonePosX( int zoneIndex )
        {
            return zoneIndex % _width;
        }

        protected int GetZonePosY( int zoneIndex )
        {
            return zoneIndex / _width;
        }
    }
}
