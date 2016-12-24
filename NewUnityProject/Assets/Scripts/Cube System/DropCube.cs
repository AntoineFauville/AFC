using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCube : MonoBehaviour {

	public GameObject prefabCube;
	public GameObject cubeOnAss;

	public Transform LaunchCube;

	public bool isCubeOnGround;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//drop it

		if(Input.GetButtonDown("dropcube") && !isCubeOnGround){
			Instantiate (prefabCube,LaunchCube.position, LaunchCube.rotation);
			isCubeOnGround = true;
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
		isCubeOnGround = false;
	}
}
