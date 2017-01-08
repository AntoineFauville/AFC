using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void QuitGame(){
		StartCoroutine ("EndGame");
		Application.CancelQuit ();
	}

	public void launchDemoTechi(){
		StartCoroutine ("launchDemoTech");
	}

	public void launchDemoGraphi(){
		StartCoroutine ("launchDemoGraph");
	}

	IEnumerator launchDemoTech (){
		yield return new WaitForSeconds (0.5f);
		SceneManager.LoadScene ("Technical Scene");
	}

	IEnumerator launchDemoGraph (){
		yield return new WaitForSeconds (0.5f);
		SceneManager.LoadScene ("");
	}
		
	IEnumerator EndGame (){
		yield return new WaitForSeconds (2.0f);
		Application.CancelQuit ();
	}
}
