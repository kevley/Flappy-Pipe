using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawn : MonoBehaviour {

    public GameObject ground;
    public float spawnTime, time;
    

    void Start()
    {
        Invoke("scroll", spawnTime);
    }

    void scroll()
    {
        Instantiate(ground, transform.position, transform.rotation);
        Invoke("scroll", spawnTime);
    }

    void Update()
    {
        time += Time.deltaTime;
    }
}
