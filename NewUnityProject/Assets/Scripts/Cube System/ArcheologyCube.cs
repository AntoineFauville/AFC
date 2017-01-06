using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcheologyCube : MonoBehaviour {

	Renderer rend;

	ObjetATrouverList OATL;

	float rouge = 0;
	float vert = 0;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		OATL = GameObject.Find ("ScriptManager").GetComponent<ObjetATrouverList> ();
	}
	
	// Update is called once per frame
	void Update () {

		rouge = ((OATL.distanceToTown - 10) / 40) * 255;
		if (rouge < 0) {
			rouge = 0;
		}
		if (rouge > 255) {
			rouge = 255;
		}
		print ("rouge "+ rouge);

		vert = ((40 - (OATL.distanceToTown - 10)) / 40) * 255;
		if (vert < 0) {
			vert = 0;
		}
		if (vert > 255) {
			vert = 255;
		}
		print ("vert " + vert);
		rend.material.color = new Color (rouge,vert,0,255);	
	}
}
