﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{







    // The target marker.
    public Transform target;

    // Angular speed in radians per sec.
    public float speed = 1.0f;
    public float Speed;
    private float singleStep;
    private Vector3 targetDirection, newDirection;
  
    void Update()
    {
        // Determine which direction to rotate towards
         targetDirection = target.position - transform.position;
       
        // The step size is equal to speed times frame time.
        singleStep = speed * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // Draw a ray pointing at our target in
       // Debug.DrawRay(transform.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);
        transform.RotateAround(target.position, target.up, Speed * Time.deltaTime);
    }


   


}
