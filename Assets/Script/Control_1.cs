using UnityEngine;
using System.Collections;

public class Control_1 : MonoBehaviour {

	public float Rotacion = 80f;
	public float Move = 10f;

	public Camera firstPerson;
	public Camera OverHead;

	private int Count = 0;

	// Use this for initialization
	void Start () 
	{
		//GetComponent<Renderer>().material.color = color;
	}

	// Update is called once per frame
	void Update ()	
	{
		Rotate ();
		Movet ();
		if (Input.GetKeyDown(KeyCode.R))
		{
			ShowCam();
		}
	}

	// Cambio de camara
	public void ShowCam() {
		if (Count % 2 == 0) {
			firstPerson.enabled = false;
			OverHead.enabled = true;
			Count++;
		} else if (Count % 2 != 0) {
			firstPerson.enabled = true;
			OverHead.enabled = false;
			Count++;
		}
	}

	// Rotacion del objeto
	void Rotate () {
		if (Input.GetKey(KeyCode.A))
			transform.Rotate (new Vector3 (0f, -Rotacion, 0f) * Time.deltaTime);
		else if (Input.GetKey(KeyCode.D))
			transform.Rotate (new Vector3 (0f, Rotacion, 0f) * Time.deltaTime);
	}

	// Movimiento del objeto
	void Movet () {
		if (Input.GetKey (KeyCode.W))
			transform.Translate (Vector3.forward * Move * Time.deltaTime);
		else if (Input.GetKey (KeyCode.S))
			transform.Translate (Vector3.back * Move * Time.deltaTime);
		else if (Input.GetKey (KeyCode.Q))
			transform.Translate (Vector3.left * Move * Time.deltaTime);
		else if (Input.GetKey (KeyCode.E))
			transform.Translate (Vector3.right * Move * Time.deltaTime);
	}
}