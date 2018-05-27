namespace Discover.Stage
{
    public enum ZoneType
    {
        Land,
    }

    public class ZonePrefabInfo
    {
        public const string Path = "Prefab/Stage/Zone";
        public const string ZoneBaseName = "ZoneBase";
    }

    public class  ZoneObjectInfo
    {
        public const string ZoneNameTemplate = "Zone_{0}_{1}";
    }
}