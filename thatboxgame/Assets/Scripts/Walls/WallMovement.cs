using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    private Vector3 offset;
    public int slideDistance = 0;
    public bool xWall = false;
    public bool yWall = false;

    void OnMouseDown()
    {
        if (xWall)
        {
            offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0f));
        }
        else if (yWall)
        {
            offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(0f, Input.mousePosition.y));    
        }
    }

    void OnMouseDrag()
    {
        if (xWall)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, 0);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
        else if (yWall)
        {
            Vector3 newPosition = new Vector3(0, Input.mousePosition.y);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }
}
