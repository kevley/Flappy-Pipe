using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bird" || collision.gameObject.tag == "ground")
        {
            GameObject.Find("gameManager").GetComponent<gameManager>().gameOver = true;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }
    }
}
