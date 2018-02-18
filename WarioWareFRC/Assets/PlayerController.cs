using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb;
    private Vector2 Force;
    private bool jumped;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        jumped = false;
    }
    
    
	// Update is called once per frame
	void Update () {

      //  Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1);
        Force = new Vector2(0, 1)*1000;
        if (Input.GetKeyDown(KeyCode.Space) && !jumped) {
            rb.AddForce(Force);
            jumped = true;
            
        }
    }
}
