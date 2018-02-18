using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class losetoneutral : MonoBehaviour {

    public float Timer = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Random.Range(1, 5);
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            SceneManager.LoadScene("between");
        }
    }
}
