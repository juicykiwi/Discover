using System.Collections.Generic;

namespace Windlight.Utility.Singleton
{
    public abstract class Singleton<T> where T : class, new()
    {
        static T _instance = null;

        // Method

        static public T instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                }

                return _instance;
            }
        }
    }
}