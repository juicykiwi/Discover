using System;
using System.Collections.Generic;

namespace Windlight.TiledMap
{
    [Serializable]
    public class TiledMapData
    {
        public int width = 0;
        public int height = 0;

        public List<TiledLayer> layers = new List<TiledLayer>();


        public TiledLayer GetTiledLayer( int layer )
        {
            return layers[layer];
        }
    }

    [Serializable]
    public class TiledLayer
    {
        public int width = 0;
        public int height = 0;

        public List<int> data = new List<int>();


        public int GetTileId( int posX, int posY )
        {
            int tileIndex = GetTileIndex(posX, posY);
            return data[tileIndex];
        }

        public int GetTileId( int tileIndex )
        {
            return data[tileIndex];
        }

        int GetTileIndex( int posX, int posY )
        {
            return (width * posY) + posX;
        }

        public int GetTilePosX( int tileIndex )
        {
            return tileIndex % width;
        }

        public int GetTilePosY( int tileIndex )
        {
            return tileIndex / width;
        }
    }
}

