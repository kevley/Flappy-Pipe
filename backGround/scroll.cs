using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour {

    public float speed, offset;
    Vector3 startPos;    

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);

        if (transform.position.x < offset)
        {
            transform.position = startPos;
        }
    }
}
