using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bestScore : MonoBehaviour {

    public static int bestScoreValue = 0;

    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        bestScoreValue = PlayerPrefs.GetInt("bestScore");

        if (scoreScript.scoreValue > bestScoreValue)
        {
            PlayerPrefs.SetInt("bestScore", scoreScript.scoreValue);
            bestScoreValue = PlayerPrefs.GetInt("bestScore");
        }
        score.text = "Best " + bestScoreValue + "";
    }
}
