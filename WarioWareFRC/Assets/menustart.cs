using UnityEngine;
using UnityEngine.SceneManagement;
public class menustart : MonoBehaviour
{

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("joj");
                SceneManager.LoadScene("between");
            }
        }
}
