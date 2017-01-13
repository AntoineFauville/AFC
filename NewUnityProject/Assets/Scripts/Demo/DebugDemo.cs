using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DebugDemo : MonoBehaviour {

	GameObject BlocageCube;

	DeathSystem DS;

	GameObject MenuCanvas;
	bool menuOpen;

	// Use this for initialization
	void Start () {
		MenuCanvas = GameObject.Find ("CanvasMenu");
		BlocageCube = GameObject.Find ("BlocageCube");
		DS = GameObject.Find ("Player").GetComponent<DeathSystem>();
		MenuCanvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Cancel") && !menuOpen) {
			MenuCanvas.SetActive (true);
			menuOpen = true;
		} else if (Input.GetButtonDown ("Cancel") && menuOpen) {
			MenuCanvas.SetActive (false);
			menuOpen = false;
		}

		//scene loading

		if (Input.GetKeyDown ("1")) {
			print ("1 pressed");
			Application.LoadLevel ("MenuScene");
		} else if (Input.GetKeyDown ("2")) {
			print ("2 pressed");
			Application.LoadLevel ("Technical Scene");
		} else if (Input.GetKeyDown ("3")) {
			print ("3 pressed");
			Application.LoadLevel ("");

		//

		} else if (Input.GetKeyDown ("4")) {
			print ("4 pressed");
			BlocageCube.GetComponent<VillageDecouvertBlocageCube> ().villageAnimLaunched = true;
			DS.EnigmeActiveeMortSystemOn = true;
		} else if (Input.GetKeyDown ("5")) {
			print ("5 pressed");

		} 
	}
}
