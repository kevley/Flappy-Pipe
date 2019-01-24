using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medal : MonoBehaviour {

    public GameObject bronze, silver, gold, plat, button;

    public AudioClip woosh;

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.PlayOneShot(woosh);

        Invoke("okButton", 1f);
    }

    void Update()
    {
        var score = scoreScript.scoreValue;

        if (score > 9 && score < 20)
        {
            Invoke("bro", 0f);
        }

        if (score > 19 && score < 30)
        {
            Invoke("sil", 0f);
        }

        if (score > 29 && score < 40)
        {
            Invoke("gol", 0f);
        }

        if (score > 39)
        {
            Invoke("pla", 0f);
        }
    }

    void okButton()
    {
        button.SetActive(true);
    }

    void bro()
    {
        bronze.SetActive(true);
    }

    void sil()
    {
        silver.SetActive(true);
    }

    void gol()
    {
        gold.SetActive(true);
    }

    void pla()
    {
        plat.SetActive(true);
    }
}
