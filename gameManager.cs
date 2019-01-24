using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public bool gameOver = false;

    public GameObject pipe, spawn, UI, ground, movement, scoreBoard, tap;

    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            movement.GetComponent<movement>().enabled = true;
            movement.GetComponent<Animator>().enabled = false;
            pipe.GetComponent<Rigidbody2D>().constraints = ~RigidbodyConstraints2D.FreezePositionY;
            spawn.SetActive(true);
            tap.SetActive(false);
            UI.SetActive(true);
        }

        if (gameOver == true)
        {
            Invoke("scoreUp", 1f);
            ground.GetComponent<scroll>().speed = 0;
            GameObject.Find("pipe").GetComponent<tapMove>().enabled = false;
            GameObject.Find("pipe").GetComponent<movement>().enabled = false;
            
            Destroy(GameObject.Find("pipe").GetComponent<playerPoint>());
            Invoke("disableScore", 1);
            Invoke("destroyBirds", 2f);
        }
    }

    void scoreUp()
    {
        scoreBoard.SetActive(true);
    }

    void disableScore()
    {
        UI.SetActive(false);
    }

    void destroyBirds()
    {
        Destroy(GameObject.Find("birdSpawn"));
    }
}
