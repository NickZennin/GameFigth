﻿using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	//Camaras
	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	void LateUpdate() {
		transform.position = player.transform.position + offset;
	}

	// Update is called once per frame
	void Update () {
		
	}

}
