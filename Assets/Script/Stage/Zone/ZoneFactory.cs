using System;
using Windlight.Data;

namespace Discover.Stage
{
    public class ZoneFactory
    {
        public static ZoneBase CreateZone()
        {
            FileInfo fileInfo = new FileInfo();
            fileInfo.path = ZonePrefabInfo.Path;
            fileInfo.fileName = ZonePrefabInfo.ZoneBaseName;

            ZoneBase Zone = DataControl.LoadDataInResources<ZoneBase>(fileInfo);
            return Zone;
        }
    }
}

