using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameQuit : MonoBehaviour {

        void OnCollisionEnter(Collision col)
    {
       
        Debug.Log("Collision Detected");
           SceneManager.LoadScene(0);

     }
    

}
