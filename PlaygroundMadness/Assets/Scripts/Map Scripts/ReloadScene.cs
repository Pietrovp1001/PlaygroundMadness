using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour {

	void Update () {//reload scene, for testing purposes
		if (Input.GetKeyDown("r")){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
