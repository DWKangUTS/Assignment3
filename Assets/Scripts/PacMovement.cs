using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMovement : MonoBehaviour
{
    float moveX, moveY;
    float moveSpeed = 10f;
    public Animator animator; 
    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);

        
    }

}
