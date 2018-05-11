using System;
using UnityEngine;

namespace Windlight.Serialization.Json
{
    public class Deserializer
    {
        public T Deserialize<T>( string text )
        {
            T deserializeData = JsonUtility.FromJson<T>(text);
            return deserializeData;
        }
    }
}

