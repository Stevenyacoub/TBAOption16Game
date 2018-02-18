using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waittween : MonoBehaviour {

    public float Timer=3;
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Random.Range(1, 5);
        Timer -= Time.deltaTime;
        if (Timer<0)
        {
            SceneManager.LoadScene(Random.Range(4, 6));
        }
	}
}
