using System;
using System.IO;
using UnityEngine;

namespace Windlight.Serialization.Json
{
    public class Serializer
    {
        public string Serialize<T>( T targetData )
        {
            string serializeText = JsonUtility.ToJson(targetData, true);
            return serializeText;
        }
    }
}

