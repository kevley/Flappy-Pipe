using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    public float sec;

    void Start()
    {
        StartCoroutine("destroyObject");
    }

    IEnumerator destroyObject()
    {
        yield return new WaitForSeconds(sec);
        Destroy(gameObject);
    }
}
