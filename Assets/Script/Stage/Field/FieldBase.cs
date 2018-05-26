using System.Collections.Generic;
using UnityEngine;
using Windlight.Data;
using Windlight.TiledMap;

namespace Discover.Stage
{
    public class FieldBase : MonoBehaviour
    {
        protected List<ZoneBase> _zoneList = new List<ZoneBase>();


        // Init field

        public void InitField( FieldInfo fieldInfo )
        {
            TiledMapData tiledMapData = fieldInfo.tiledMapData;

            foreach (TiledLayer layer in tiledMapData.layers)
            {
                for (int tileIndex = 0; tileIndex < layer.data.Count; ++tileIndex)
                {
                    int posX = layer.GetTilePosX(tileIndex);
                    int posY = layer.GetTilePosY(tileIndex);
                }
            }
        }
    }
}
