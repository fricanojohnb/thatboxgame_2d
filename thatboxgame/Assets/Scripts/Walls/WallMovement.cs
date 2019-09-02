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
        offset = gameObject.transform.position -
        Camera.main.ScreenToWorldPoint(new Vector3(Mathf.Round(Input.mousePosition.x), Mathf.Round(Input.mousePosition.y)));
    }

    void OnMouseDrag()
    {
        if (xWall)
        {
            Vector3 newPosition = new Vector3(Mathf.Round(Input.mousePosition.x), gameObject.transform.position.y);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
        else if (yWall)
        {
            Vector3 newPosition = new Vector3(gameObject.transform.position.x, Mathf.Round(Input.mousePosition.y));
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }
}
