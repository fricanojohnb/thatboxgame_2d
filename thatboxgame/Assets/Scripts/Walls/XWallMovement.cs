using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XWallMovement : MonoBehaviour
{
    private Vector3 offset;
    public int slideDistance = 0;
    private bool isColliding = false;
    private bool mouseClicked = false;

    void OnMouseDown()
    {
        offset = gameObject.transform.position -
        Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0f, 0f));
        mouseClicked = true;
    }

    private void OnMouseUp() {
        mouseClicked = false;
    }

    private void Update()
    {
        if (!isColliding && mouseClicked)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, 0);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isColliding = true;
        transform.position = transform.position - offset;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isColliding = false;
    }
}
