using System;
using Windlight.Data;

namespace Discover.Stage
{
    public class FieldFactory
    {
        public static FieldBase CreateField( FieldInfo fieldInfo )
        {
            FileInfo fileInfo = new FileInfo();
            fileInfo.path = FieldPrefabInfo.Path;
            fileInfo.fileName = FieldPrefabInfo.FieldBaseName;

            FieldBase field = DataControl.LoadDataInResources<FieldBase>(fileInfo);
            return field;
        }
    }
}