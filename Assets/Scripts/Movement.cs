using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float speed = 2f;
    
    Rigidbody rb;


    public float horizontal;
    public float vertical;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
       
    }

    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);

        

    }


}
