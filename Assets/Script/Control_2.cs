using UnityEngine;
using System.Collections;

public class Control_2 : MonoBehaviour {

	// Variables
	private Rigidbody rb;

	public float speed= 500f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
		

	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal2");
		float moveVertical = Input.GetAxis ("Vertical2");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed * Time.deltaTime);
	}
}
