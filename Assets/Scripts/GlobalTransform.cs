using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// data received from send controller transform class 
// in order to pass transfrom data to cube when in vr
public class GlobalTransform : MonoBehaviour
{
    private static GlobalTransform instance;
    public static GlobalTransform Instance
    {
        get
        {
            if (instance != null)
            {
                return instance;
            }

            GameObject managerObj = new GameObject("GlobalTransform");
            instance = managerObj.AddComponent<GlobalTransform>();
            return instance;
        }
    }
}
