using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public static Reset instance;
    private List<int> oitentialAgles = new List<int> { 45, 60, 120, -60, -45 };
    public GameObject ball;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        InstantiateBall();
    }

    public void InstantiateBall()
    {
        int angleIndex = Random.Range(0, 4);
        GameObject ballCopy = Instantiate(ball, transform.position, Quaternion.Euler(angleIndex, 0, 0));
    }
}
