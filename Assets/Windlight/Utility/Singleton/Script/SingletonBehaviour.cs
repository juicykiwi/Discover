using System.Collections.Generic;
using UnityEngine;

namespace Windlight.Utility.Singleton
{
    public abstract class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        static T _instance = null;

        static bool _applicationQuit = false;

        // Method

        public static T instance
        {
            get
            {
                if (_instance == null)
                {
                    try
                    {
                        if( _applicationQuit == true )
                        {
                            Debug.LogWarningFormat("{0}.instance", typeof(T).Name);
                            Debug.LogWarning("_applicationQuit is true");
                            return null;
                        }

                        GameObject singletonObj = new GameObject(typeof(T).Name);
                        _instance = singletonObj.AddComponent<T>();

                        _instance.transform.position = Vector3.zero;
                        _instance.transform.rotation = Quaternion.identity;

                        DontDestroyOnLoad(_instance.gameObject);
                    }
                    catch( System.Exception exception )
                    {
                        Debug.LogErrorFormat("{0}.instance", typeof(T).Name);
                        Debug.LogError(exception.Message);
                    }
                }

                return _instance;
            }
        }

        static public void CreateInstance()
        {
            T t = SingletonBehaviour<T>.instance;
            Debug.Log("CreateInstance : " + t.name);
        }

        protected virtual void Awake()
        {
            _instance = GetComponent<T>();
        }

        void OnApplicationQuit()
        {
            _applicationQuit = true;
        }
    }
}