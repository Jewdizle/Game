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

        if (Random.Range(-1f, 1) < 0)
        {
            rb.AddForce(-ballThrust, 0, 0, ForceMode.Acceleration);
        }
        else
        {
            rb.AddForce(ballThrust, 0, 0, ForceMode.Acceleration);
        }
    }
}
