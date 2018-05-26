using System;
using UnityEngine;

namespace Windlight.UnityObject
{
    public class UnityObjectHelper
    {
        public static void SetParent( GameObject parent, GameObject child, bool resetTransform )
        {
            child.transform.SetParent(parent.transform);
            if (resetTransform == true)
            {
                ResetTransform(child.gameObject);
            }
        }

        public static void ResetTransform( GameObject gameObject )
        {
            gameObject.transform.localPosition = Vector3.zero;
            gameObject.transform.localScale = Vector3.one;
            gameObject.transform.localRotation = Quaternion.identity;
        }
    }
}