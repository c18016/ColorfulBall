﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour {

	//public int count = 0;
	public GameController Score;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Ball") {

		}
	}
}
