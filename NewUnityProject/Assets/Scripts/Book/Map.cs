using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

	GameObject MapGameObject;
	GameObject PanelbookCamera;

	bool mapOpen = false;

	// Use this for initialization
	void Start () {
		MapGameObject = GameObject.Find ("CameraMap");
		PanelbookCamera = GameObject.Find ("NewBookPanelMapOnly");
		MapGameObject.SetActive (false);
		PanelbookCamera.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Map") && !mapOpen) {
			mapOpen = true;
			MapGameObject.SetActive (true);
			PanelbookCamera.SetActive (true);
		}
		else if (Input.GetButtonDown ("Map") && mapOpen) {
			mapOpen = false;
			MapGameObject.SetActive (false);
			PanelbookCamera.SetActive (false);
		}
	}
}
