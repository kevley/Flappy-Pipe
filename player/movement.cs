using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float tiltForce = 5;

    Quaternion downRotate;

    void Start()
    {
        downRotate = Quaternion.Euler(0, 0, -15f);
    }

    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, downRotate, tiltForce * Time.deltaTime);
    }


}

