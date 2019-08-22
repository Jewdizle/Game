using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int one;
    public int two;

    private UIManager uiMan;

    private void Start()
    {
        uiMan = GetComponent<UIManager>();
    }

    public void OneScore()
    {
        one++;
        uiMan.UpdateScore(one, two);
    }

    public void TwoScore()
    {
        two++;
        uiMan.UpdateScore(one, two);

        float ratio = ((float)one+1) / ((float)two+1);
    }
}