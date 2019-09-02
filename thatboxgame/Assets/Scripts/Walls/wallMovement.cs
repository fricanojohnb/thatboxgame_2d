using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{
    private Vector3 offsetx;
    private Vector3 offsety;
    private bool mouseClicked = false;
    private bool isColliding = false;
    public int slideDistance = 0;
    public bool xWall = false;
    public bool yWall = false;

    void OnMouseDown()
    {
        if (yWall)
        {
            offsety = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(0f, Input.mousePosition.y, 0f));
            mouseClicked = true;
        }
        if (xWall)
        {
            offsetx = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0f, 0f));
            mouseClicked = true;
        }
    }

    private void OnMouseUp()
    {
        mouseClicked = false;
    }

    private void Update()
    {
        if (!isColliding && mouseClicked)
        {
            if (yWall)
            {
                {
                    Vector3 newPosition = new Vector3(0, Input.mousePosition.y);
                    transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offsety;
                }
            }
            if (xWall)
            {
                {
                    Vector3 newPosition = new Vector3(Input.mousePosition.x, 0);
                    transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offsetx;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isColliding = true;
        if (yWall)
        {
            transform.position = transform.position - offsety;
        }
        if (xWall)
        {
            transform.position = transform.position - offsetx;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isColliding = false;
    }
}
