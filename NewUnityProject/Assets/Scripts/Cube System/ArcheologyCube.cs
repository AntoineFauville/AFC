using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcheologyCube : MonoBehaviour {

	Renderer rend;

	//ObjetATrouverList OATL;

	ZoneGestion ZG;

	float rouge = 0;
	float vert = 0;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		//OATL = GameObject.Find ("ScriptManager").GetComponent<ObjetATrouverList> ();
		ZG = GameObject.Find ("ScriptManager").GetComponent<ZoneGestion> ();
	}
	
	// Update is called once per frame
	void Update () {

		float distanceRouge = Vector3.Distance (transform.position, ZG.ListDeZone [0].transform.position);
		float distanceVert = Vector3.Distance (ZG.ListDeZone [0].transform.position, transform.position);

		print (distanceRouge);

		rouge = (distanceRouge / 50) * 255;
		if (rouge < 0) {
			rouge = 0;
		}
		if (rouge > 255) {
			rouge = 255;
		}
		//print ("rouge "+ rouge);

		vert = (distanceVert / 50) * 255;
		if (vert < 0) {
			vert = 0;
		}
		if (vert > 255) {
			vert = 255;
		}
		//print ("vert " + vert);
		rend.material.color = new Color (rouge,vert,0,255);	
	}
}
