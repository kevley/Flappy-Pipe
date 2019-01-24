using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapMove : MonoBehaviour
{
    public float force = 10;

    Rigidbody2D r2;
    Quaternion upRotate;

    void Start()
    {
        r2 = GetComponent<Rigidbody2D>();
        upRotate = Quaternion.Euler(0, 0, 10f);
    }

    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            transform.rotation = upRotate;

            r2.velocity = Vector2.zero;
            r2.AddForce(new Vector2(0, force));
        }
    }
}
