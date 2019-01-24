using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdSound : MonoBehaviour {

    public AudioClip punch;
    bool played = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pipe" || collision.gameObject.tag == "bird")
        {
            if (played == false)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.PlayOneShot(punch);
                played = true;
            }
        }
    }
}
