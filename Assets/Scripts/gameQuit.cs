using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameQuit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        onCollisionEnter();
	}

    void onCollisionEnter()
    {
        Debug.Log("Collision Detected")
        SceneManager.LoadScene(0);
        
    }

}
