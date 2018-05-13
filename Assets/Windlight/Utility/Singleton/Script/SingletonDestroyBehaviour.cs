using System.Collections.Generic;
using UnityEngine;

namespace Windlight.Utility.Singleton
{
    public abstract class SingletonDestroyBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        static T _instance = null;

        // Method

        public static T instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.Log("SingletonFindBehaviour.instance - instance is null : " + typeof(T).Name);
                }

                return _instance;
            }
        }

        protected virtual void Awake()
        {
            _instance = GetComponent<T>();
        }

        protected virtual void OnDestory()
        {
            _instance = null;
        }
    }
}