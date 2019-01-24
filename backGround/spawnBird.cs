using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBird : MonoBehaviour {

    public GameObject bird;

    public float spawnMin, spawnMax, spawnYRange;

    void Start()
    {
        Invoke("spawn", 0);
    }

    void spawn()
    {
        Instantiate(bird, transform.position + new Vector3(0, Random.Range(-spawnYRange, spawnYRange), 0), transform.rotation);
        Invoke("spawn", Random.Range(spawnMin, spawnMax));
    }
}
