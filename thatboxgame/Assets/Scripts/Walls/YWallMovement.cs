using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YWallMovement : MonoBehaviour
{
    private bool moving;

    public Vector2 direction;

    private void Start() {
        moving = false;
    }

    void OnMouseDown(){
        moving = true;
    }

    private void Update(){
        if (moving){
            Vector3 newPosition = new Vector3(Input.mousePosition.x, 0);
            transform.Translate(direction);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        moving = !moving;
        if (direction.Equals(Vector2.down)){
            direction = Vector2.up;
        }
        else {
            direction = Vector2.down;
        }
        Debug.Log("OnCollisionEnter2D");
    }
}
