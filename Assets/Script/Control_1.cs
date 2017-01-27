using UnityEngine;
using System.Collections;

public class Control_1 : MonoBehaviour {

	private Rigidbody rb;

	public float speed= 500f;

	//private int Count = 0;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update ()	
	{
		/*if (Input.GetKeyDown(KeyCode.R))
		{
			ShowCam();
		}*/
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed * Time.deltaTime);
	}
	/*
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
	}*/
}
