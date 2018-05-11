using System.IO;
using UnityEngine;
using Windlight.Serialization.Json;

namespace Windlight.Data
{
    public class DataControl
    {
        public static T LoadJson<T>( FileInfo fileInfo ) where T : class, new()
        {
            TextAsset loadTextAsset = Resources.Load<TextAsset>(fileInfo.GetAllPath());
            if (loadTextAsset == null)
            {
                Debug.LogErrorFormat("Windlight DataControl.LoadJson() loadTextAsset is null. Load data name : {0}", fileInfo.GetAllPath());
                return null;
            }

            Deserializer deserialize = new Deserializer();
            T deserializeData = deserialize.Deserialize<T>(loadTextAsset.text);

            return deserializeData;
        }

        public static void SaveJson<T>( T targetData, FileInfo fileInfo ) where T : class, new()
        {
            if (targetData == null)
            {
                Debug.LogErrorFormat("Windlight DataControl.SaveJson() targetData is null. Save data name : {0}", fileInfo.GetAllPath());
                return;
            }

            if (Directory.Exists(fileInfo.path) == false)
            {
                Directory.CreateDirectory(fileInfo.path);
            }

            Serializer serializer = new Serializer();
            string serializeText = serializer.Serialize<T>(targetData);

            File.WriteAllText(fileInfo.GetAllPathIncludeExtension(), serializeText);
        }
    }
}