using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decider : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 1f; 
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>();

        if(Random.Range(-1f, 1) < 0)
        {
            rb.AddForce(force, 0, 0);

        }
        else
        {
            rb.AddForce(-force, 0, 0);
        }
    }
}
