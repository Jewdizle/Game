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

    private void Start()
    {
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
    }


    public void MovePaddle(float inputAxisInfo)
    {
        Vector3 clampedPosition = gameObject.transform.position + new Vector3(0, 0, inputAxisInfo * speed);
        clampedPosition.z = Mathf.Clamp(clampedPosition.z, -clamp, clamp);
        gameObject.transform.position = clampedPosition;
    }
}
