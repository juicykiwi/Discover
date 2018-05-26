using System;
using Windlight.Data;

namespace Windlight.TiledMap
{
    public class TiledMapImport
    {
        const string TiledMapDataPathInResources = "Data/TiledMap";

        public static TiledMapData ImportTileMapData( string jsonFileName )
        {
            FileInfo fileInfo = new FileInfo();
            fileInfo.path = TiledMapDataPathInResources;
            fileInfo.fileName = jsonFileName;

            TiledMapData loadedTiledMapData = DataControl.LoadJson<TiledMapData>(fileInfo);
            return loadedTiledMapData;
        }
    }
}