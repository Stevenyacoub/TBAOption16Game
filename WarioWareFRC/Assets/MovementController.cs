using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour {
    [SerializeField]
    Animator anim;

    Rigidbody2D rb;

    public static bool win { get; internal set; }

    public IEnumerator playAnimation(string boolToSet, float delay)
    {
        yield return new WaitForSeconds(delay);
        anim.SetBool(boolToSet, true);
    }
	void Start () {
        
        anim = GetComponent<Animator>();
        anim.speed = Random.Range(0.5f,1.0f); //perfect values
        Debug.Log(anim.speed);
        StartCoroutine(playAnimation("Triggered",2.0f));
        bool win = true; 
   	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Man")
        {
            bool win = false;
            SceneManager.LoadScene("losetween");
        }
    }
}

