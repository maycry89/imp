﻿using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

    public GameObject rocks;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateObstacle", 1f, 2f);
	}
	
	// Update is called once per frame
	void CreateObstacle(){
        Instantiate(rocks);
	}
}
