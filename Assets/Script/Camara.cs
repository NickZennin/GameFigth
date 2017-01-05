using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	//Camaras
	public Camara Menu;
	public Camara Instruccions;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//OnClick ();
	}

	// Cambio de camara
	public void OnClick(){
		Menu.enabled = false;
		Instruccions.enabled = true;
	}
}
