using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour {
    private int points;
    public float num;
    bool up = false;
	// Use this for initialization
	void Start (){

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up")) {
            up = true;
        }

        if (Input.GetKeyUp("up")) {
            up = false;
        }

        if (up && Input.GetKeyUp("space")) {
            points += 1;
            Debug.Log(points);
            transform.Translate(new Vector3(0, num, 0));
        }

        if (points == 8) {
            Debug.Log("jfakfghskdfhgjsddfghlw");
        }
    }
}
