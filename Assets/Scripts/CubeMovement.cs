using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    Vector3 mousePosOffset;
    Vector2 turn;

    private float zDis;

    [SerializeField]
    float posScaleFactor = 1.1f;

    [SerializeField]
    float negScaleFactor = 0.9f;

    private void Start()
    {
        zDis = Camera.main.ScreenToWorldPoint(transform.position).z + 20;
    }

    private Vector3 GetMouseWorldPos()
    {
        var v = Input.mousePosition;
        v.z = -10.0f;
        v = Camera.main.ScreenToWorldPoint(v);
        return Camera.main.ScreenToWorldPoint(v);
    }

    private void OnMouseDown()
    {
        //mousePosOffset = gameObject.transform.position - GetMouseWorldPos();
        //zDis = Camera.main.ScreenToWorldPoint(transform.position).z;
    }

    private void OnMouseDrag()
    {
        // hold A and left mouse button to move cube
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = GetMouseWorldPos() + mousePosOffset;
            Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDis);
            Vector3 NewWorldPos = Camera.main.ScreenToWorldPoint(screenPos);
            transform.position = NewWorldPos;
        }
        // hold S and left mouse button to move cube
        if (Input.GetKey(KeyCode.S))
        {
            turn.x += Input.GetAxis("Mouse X");
            turn.y += Input.GetAxis("Mouse Y");
            transform.localRotation = Quaternion.Euler(turn.y, -turn.x, 0);
        }
        // hold D and move scroll wheel to change cube size
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                transform.localScale *= posScaleFactor;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                transform.localScale *= negScaleFactor;
            }
        }

    }
}
