using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpCube : MonoBehaviour {

	DropCube dc;
	GameObject Player;

	SanityGestion SG;

	// Use this for initialization
	void Start () {
		dc = GameObject.Find ("Player").GetComponent<DropCube>();
		SG = GameObject.Find ("Player").GetComponent<SanityGestion>();
		Player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(Player.transform.position, transform.position);

		if (Input.GetButtonDown ("dropcube") && dc.isCubeOnGround && distance < 3) {
			SG.sanity = 1;
			dc.StartCoroutine ("returnCubeBool");
			Destroy (this.gameObject);
		}
	}
}
