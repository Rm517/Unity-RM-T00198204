using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballScript : MonoBehaviour
{
    Rigidbody rb;
    internal void throwSnowball(Transform thrower)
    {
        rb = GetComponent<Rigidbody>();

        if (rb != null)
            print("found rigid body");

        else print("could not find rigid body");

        rb.AddExplosionForce(500, thrower.position, 3);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
