using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKey("p")) {
            Debug.Log("LA");
            SceneManager.LoadScene("Level1");
        }
    }
}
