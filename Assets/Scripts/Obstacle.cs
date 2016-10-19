using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour {

    public Vector3 velocity = new Vector3(-4f, 0f, 0f);
    
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-4f, 0f, 0f);
        transform
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}






