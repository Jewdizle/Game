using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text playerOneScore;
    public Text playerTwoScore;



    void Start()
    {
        playerOneScore.text = "0";
        playerTwoScore.text = "0";

    }

    public void UpdateScore(int p1Score, int p2Score)
    {
        playerOneScore.text = p1Score.ToString();
        playerTwoScore.text = p2Score.ToString();
    }
}
