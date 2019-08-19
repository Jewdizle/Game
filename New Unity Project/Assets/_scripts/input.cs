using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    public float speed = 1f;
    public float clamp = 1f;

    // Update is called once per frame
    void Update()
    {
        MovePaddle(Input.GetAxis("Horizontal"));
    }

    public void MovePaddle(float inputAxisInfo)
    {
        Vector3 clampedPosition = gameObject.transform.position + new Vector3(0, 0, inputAxisInfo * speed);
        clampedPosition.z = Mathf.Clamp(clampedPosition.z, -clamp, clamp);
        gameObject.transform.position = clampedPosition;
    }
}
