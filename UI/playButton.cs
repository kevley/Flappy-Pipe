using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour {

    void OnMouseDown()
    {
        Invoke("load", .5f);
        transform.position = transform.position - new Vector3(0, 5 * Time.deltaTime, 0);
    }

    void OnMouseUp()
    {
        transform.position = transform.position + new Vector3(0, 5 * Time.deltaTime, 0);
    }
    
    

    void load()
    {
        SceneManager.LoadScene(0);
        scoreScript.scoreValue = 0;
    }
}
