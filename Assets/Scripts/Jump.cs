using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    int JumpCount = 0;
    public int MaxJumps = 1; //Maximum amount of jumps (i.e. 2 for double jumps)
    Rigidbody rb;

    void Start()
    {
        JumpCount = MaxJumps;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            if (JumpCount > 0)
            {
                JumpPlayer();
            }
        }
    }
    public void JumpPlayer()
    {
        rb.velocity = transform.up * 4.5f;
        JumpCount -= 1;
    }
    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "ground")
        {
            JumpCount = MaxJumps;
        }
    }
}
