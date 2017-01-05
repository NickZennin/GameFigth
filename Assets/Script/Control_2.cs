using UnityEngine;
using System.Collections;

public class Control_2 : MonoBehaviour {

	// Variables
	public float Rotacion = 80f;
	public float Move = 10f;

	public Camera firstPerson;
	public Camera OverHead;

	private int count = 0;

	// Use this for initialization
	void Start () {

	}
		

	// Update is called once per frame
	void Update () {
		Rotate ();
		Movet ();
		if (Input.GetKeyDown(KeyCode.RightControl))
		{
			ShowCam();
		}
	}

	// Cambio de camara
	public void ShowCam() {
		if (count % 2 == 0) {
			firstPerson.enabled = false;
			OverHead.enabled = true;
			count++;
		} else if (count % 2 != 0) {
			firstPerson.enabled = true;
			OverHead.enabled = false;
			count++;
		}
	}

	// Rotacion del objeto
	void Rotate () {
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate (new Vector3 (0f, -Rotacion, 0f) * Time.deltaTime);
		else if (Input.GetKey(KeyCode.RightArrow))
			transform.Rotate (new Vector3 (0f, Rotacion, 0f) * Time.deltaTime);
	}

	// Movimiento del objeto
	void Movet () {
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.forward * Move * Time.deltaTime);
		else if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (Vector3.back * Move * Time.deltaTime);
		else if (Input.GetKey (KeyCode.RightShift))
			transform.Translate (Vector3.left * Move * Time.deltaTime);
		else if (Input.GetKey (KeyCode.Alpha1))
			transform.Translate (Vector3.right * Move * Time.deltaTime);
	}
}
