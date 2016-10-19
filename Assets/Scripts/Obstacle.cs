using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour {

    public Vector3 velocity = new Vector3(-4f, 0f, 0f);
    public float range = 4;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-4f, 0f, 0f);
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}






