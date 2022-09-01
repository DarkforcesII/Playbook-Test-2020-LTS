using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    Vector3 mousePosOffset;

    private Vector3 GetMouseWorldPos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        mousePosOffset = gameObject.transform.position - GetMouseWorldPos();
        print("Down");
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mousePosOffset;
        print("Moved");
    }
}
