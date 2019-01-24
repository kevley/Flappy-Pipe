using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class number : MonoBehaviour {

    public GameObject[] num;
    public int modTimes;

    void Update()
    {
        int score = scoreScript.scoreValue;

        string stringScore = score.ToString(); // convert score to string
        stringScore = stringScore.Substring(0, stringScore.Length - modTimes); // removes length of string by 1
        int lastDig = int.Parse(stringScore); // convert string to int

        lastDig = lastDig % 10;

        num[lastDig].SetActive(true);
    }
}
