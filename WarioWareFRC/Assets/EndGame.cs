using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public float Timer = 3;
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            if(MovementController.win == true)
            {
                SceneManager.LoadScene("wintween");
            }

            if (MovementController.win == false)
            {
                SceneManager.LoadScene("losetween");
            }
        }
    }
}
