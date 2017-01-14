using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ThirdPersonCamera;

public class MoveCamNoFollow : MonoBehaviour {

	Follow F;

	public float TimeBeforeBackToCam; 

	// Use this for initialization
	void Start () {
		F = GameObject.Find ("Main Camera Main").GetComponent<Follow> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			F.enabled = false;
		} else if (Input.GetButtonUp ("Fire1")) {
			StartCoroutine ("putCamBack");
		}
	}

	IEnumerator putCamBack (){
		yield return new WaitForSeconds (TimeBeforeBackToCam);
		F.enabled = true;
	}
}
