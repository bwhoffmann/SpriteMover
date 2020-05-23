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
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
}
