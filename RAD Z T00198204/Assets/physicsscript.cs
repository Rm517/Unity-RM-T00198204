using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsscript : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb= GetComponent<Rigidbody>();
        if (rb == null)
            print("found rigid body");
        else
            print("no rigid body found");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        rb.AddExplosionForce (5000, transform.position + new Vector3 (0, -1, 0), 1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }
}
