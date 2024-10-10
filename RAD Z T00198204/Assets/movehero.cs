using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movehero : MonoBehaviour
{
    Rigidbody rb;
    Animator animator;
    GameObject snowballCloneTemplate;
    // Start is called before the first frame update
    void Start()
    {
        //     animator = GetComponent<Animator>();
        if (animator == null)
            print("could not find animator component");

        else
            print("animator component found");
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("is running" , false);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(snowballCloneTemplate , transform.position + transform.forward, Quaternion.identity);
            GameObject newSnowballGO = Instantiate (snowballCloneTemplate , transform.position, Quaternion.identity);
            snowballScript myNewSnowball = newSnowballGO.GetComponent<snowballScript>();
            myNewSnowball.throwSnowball(transform);
        }

        if (Input.GetKey(KeyCode.W))   
        transform.position += transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, 30 * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.down, 30 * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime;


    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
       
        
        //collision.gameObject.transform.position += Vector3.forward;
       
        footballScript myFootball = collision.gameObject.GetComponent<footballScript>();
       if (myFootball != null)
       {
           myFootball.Kick();
       }
    }
}
