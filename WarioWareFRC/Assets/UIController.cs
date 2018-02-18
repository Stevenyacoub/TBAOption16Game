using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    Text Popup;
    public IEnumerator showPopup()
    {
        yield return new WaitForSeconds(.3f);
        Popup.enabled = true;
        yield return new WaitForSeconds(1.0f);
        Popup.enabled = false;
    }
    void Start () {
        Popup = GetComponent<Text>();
        StartCoroutine(showPopup());
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}


