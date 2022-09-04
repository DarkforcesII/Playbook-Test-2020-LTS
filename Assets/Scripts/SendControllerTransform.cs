using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendControllerTransform : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        GlobalTransform.Instance.transform.position = transform.position;
        GlobalTransform.Instance.transform.rotation = transform.rotation;
    }
}
