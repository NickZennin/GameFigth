using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {
		
	public void StartLoad (int number) {
		SceneManager.LoadScene (number);
	}

	public void ExitLoad() {
		Application.Quit ();
	}
}
