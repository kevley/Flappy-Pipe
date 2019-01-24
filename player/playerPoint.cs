using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPoint : MonoBehaviour {

    public AudioClip point;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "trigger")
        {
            scoreScript.scoreValue += 1;
        }

        if (collision.gameObject.tag == "trigger")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(point);
        }
    }
}
