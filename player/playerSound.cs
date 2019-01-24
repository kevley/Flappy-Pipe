using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSound : MonoBehaviour {

    public AudioClip punch, wing, dead;

    bool played = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            if (played == false)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.PlayOneShot(punch);
                played = true;
            }
            
        }
    }

    void Update()
    {
        var go = GameObject.Find("gameManager").GetComponent<gameManager>().gameOver;

        if (Input.GetMouseButtonDown(0) && go == false || Input.GetKeyDown("space") && go == false)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(wing);
        }
    }
}
	
	
