using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goalZone;

    public string teamName;
    public ScoreManager sm;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        Reset.instance.InstantiateBall();

        if(teamName == "one")
        {
            sm.OneScore();
        }
        
        if(teamName == "two")
        {
            sm.TwoScore();
        }
    }
}
