using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {

    public Animator anim;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pipe" || collision.gameObject.tag == "bird")
        {
            anim.SetTrigger("dead");

            Destroy(GetComponent<destroy>());
            GetComponent<move>().enabled = false;
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }  

        if (collision.gameObject.tag == "destroyBird")
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Invoke("startAnim", Random.Range(0f, 1.7f));

        anim = GetComponent<Animator>();
    }

    void startAnim()
    {
        gameObject.GetComponent<Animator>().enabled = true;
    }
}
