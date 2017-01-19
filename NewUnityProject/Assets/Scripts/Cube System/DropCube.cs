using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropCube : MonoBehaviour {

	public GameObject prefabCube;
	public GameObject cubeOnAss;

	GameObject ScanningPanel; 

	public Transform LaunchCube;

	public bool isCubeOnGround;
	// Use this for initialization
	void Start () {
		ScanningPanel = GameObject.Find ("Scanning");
		ScanningPanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		//drop it

		if(Input.GetButtonDown("dropcube") && !isCubeOnGround){
			Instantiate (prefabCube,LaunchCube.position, LaunchCube.rotation);
			isCubeOnGround = true;
			ScanningPanel.SetActive (true);
			//StartCoroutine ("returnCubeBool");
		}

		//pick it up
		if (isCubeOnGround) {
			cubeOnAss.SetActive (false);
		} else {
			cubeOnAss.SetActive (true);
		}

	}

	IEnumerator returnCubeBool () {
		yield return new WaitForSeconds (0.3f);
		ScanningPanel.SetActive (false);
		isCubeOnGround = false;
	}
}
