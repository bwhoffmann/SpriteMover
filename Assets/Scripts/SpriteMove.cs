using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMove: MonoBehaviour
{
    public float moveSpeed = 0.1f;
   void Start()
   {

   }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = Vector3.zero;
        }
        // Checks if the Shift Key is pressed
        if(Input.GetKey(KeyCode.LeftShift))
        {
            //If shift is pressed, move the sprite one unit for every arrow press
            if(Input.GetKeyDown(KeyCode.UpArrow)) {
                transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
            if(Input.GetKeyDown(KeyCode.RightArrow)) {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
            if(Input.GetKeyDown(KeyCode.LeftArrow)) {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
            if(Input.GetKeyDown(KeyCode.DownArrow)) {
                transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            //If Control is pressed, moves the sprite faster the direction pressed
            if(Input.GetKey(KeyCode.UpArrow)) {
                transform.position += Vector3.up * moveSpeed * Time.deltaTime * 3;
        }
            if(Input.GetKey(KeyCode.RightArrow)) {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime * 3;
        }
            if(Input.GetKey(KeyCode.LeftArrow)) {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime * 3;
        }
            if(Input.GetKey(KeyCode.DownArrow)) {
                transform.position += Vector3.down * moveSpeed * Time.deltaTime * 3;
        }
        }

        else {
            //If shift and control not pressed, moves the sprite continuously in the direction pressed
            if(Input.GetKey(KeyCode.UpArrow)) {
                transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
            if(Input.GetKey(KeyCode.RightArrow)) {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
            if(Input.GetKey(KeyCode.LeftArrow)) {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
            if(Input.GetKey(KeyCode.DownArrow)) {
                transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        }
    }
}



