using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehaviour : MonoBehaviour
{
    private Rigidbody rb;
    public float ballThrust;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(transform.forward * ballThrust);
    }
}
