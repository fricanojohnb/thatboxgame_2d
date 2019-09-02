using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    private Vector3 offset;

    void OnMouseDown()
    {
        offset = gameObject.transform.position -
        Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Mathf.Round(Input.mousePosition.x), Mathf.Round(Input.mousePosition.y, 10.0f));
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }
}
