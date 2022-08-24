using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    // FixedUpdate is called for calculating Physics
    void FixedUpdate()
    {
        //add 2000 force on z-axis
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
