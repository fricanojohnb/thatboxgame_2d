using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YWallMovement : MonoBehaviour
{
    private Vector3 offset;
    public int slideDistance = 0;
    private bool mouseClicked = false;
    private bool isColliding = false;

    void OnMouseDown()
    {
        offset = gameObject.transform.position -
        Camera.main.ScreenToWorldPoint(new Vector3(0f, Input.mousePosition.y, 0f));    
        mouseClicked = true;
    }

    private void OnMouseUp() {
        mouseClicked = false;
    }

    private void Update()
    {
        if (!isColliding && mouseClicked){
            Vector3 newPosition = new Vector3(0, Input.mousePosition.y);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other) {      
        isColliding = true;
        transform.position = transform.position - offset;
    }

    private void OnCollisionExit2D(Collision2D other) {
        isColliding = false;
    }
}
