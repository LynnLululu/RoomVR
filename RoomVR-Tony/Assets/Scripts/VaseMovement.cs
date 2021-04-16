﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 6f;
    private float speed0 = 0f;
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
           
                transform.Translate(Vector3.left * speed0 * Time.deltaTime);
               
        }

    }

    public void MoveForward()
    {
        speed0 = speed;
    }

    public void Stop()
    {
        speed0 = 0f;
    }

}
