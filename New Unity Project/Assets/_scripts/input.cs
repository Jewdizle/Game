using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerController
{
    player1,
    player2
}

public class input : MonoBehaviour
{
    public PlayerController playerSetting;
    public float speed = 1f;
    public float clamp = 1f;
    public string axisName;
    public string punchAxis;
    private bool punching;
    private Rigidbody rb;
    public float punchPower;
    private float startX;
    public float clampX;

    private void Start()
    {
        startX = transform.position.x;

        rb = GetComponent<Rigidbody>();

        if(playerSetting == PlayerController.player1)
        {
            axisName = "player1";
        }
        if (playerSetting == PlayerController.player2)
        {
            axisName = "player2";
        }
    }

    void Update()
    {
        MovePaddle(Input.GetAxis(axisName));

        if (Input.GetKey(KeyCode.Space))
        {
            punching = true;
        }
        if(punching == true)
        {
            Punch();
        }

        
    }

    public void Punch()
    {
        rb.AddForce(transform.forward * punchPower);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, startX, clampX), transform.position.y, transform.position.z);
    }

    public void MovePaddle(float inputAxisInfo)
    {
        Vector3 clampedPosition = gameObject.transform.position + new Vector3(0, 0, inputAxisInfo * speed);
        clampedPosition.z = Mathf.Clamp(clampedPosition.z, -clamp, clamp);
        gameObject.transform.position = clampedPosition;
    }
}
