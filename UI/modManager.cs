using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modManager : MonoBehaviour {

    public GameObject[] digit;

    void Update()
    {
        int score = scoreScript.scoreValue;

        if (score < 10)
        {
            digit[0].SetActive(true);
        }

        if (score > 9 && score < 100)
        {
            digit[0].SetActive(true);
            digit[1].SetActive(true);
        }

        if (score > 99 && score < 1000)
        {
            digit[0].SetActive(true);
            digit[1].SetActive(true);
            digit[2].SetActive(true);
        }
    }
}
