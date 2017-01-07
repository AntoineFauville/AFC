using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

	GameObject MapGameObject;
	GameObject PanelbookCamera;

	GameObject BigArea;
	GameObject SmallArea;

	GameObject ImageMapSmall;
	GameObject ImageMapZoneSmall;
	GameObject ImageMapVillage;
	GameObject ImageMapZoneVillage;

	ZoneGestion ZG;

	bool mapOpen = false;

	// Use this for initialization
	void Start () {
		MapGameObject = GameObject.Find ("CameraMap");
		PanelbookCamera = GameObject.Find ("NewBookPanelMapOnly");

		ImageMapSmall = GameObject.Find ("ImageMapSmall");
		ImageMapZoneSmall = GameObject.Find ("ImageMapZoneSmall");
		ImageMapVillage = GameObject.Find ("ImageMapVillage");
		ImageMapZoneVillage = GameObject.Find ("ImageMapZoneVillage");

		ImageMapSmall.SetActive(false);
		ImageMapZoneSmall.SetActive(false);
		ImageMapVillage.SetActive(false);
		ImageMapZoneVillage.SetActive(false);

		MapGameObject.SetActive (false);
		PanelbookCamera.SetActive (false);

		BigArea = GameObject.Find ("SphereVillage");
		SmallArea = GameObject.Find ("SphereSmall");

		SmallArea.SetActive(false);
		BigArea.SetActive(false);

		ZG = GameObject.Find ("ScriptManager").GetComponent<ZoneGestion> ();
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
			
		if (ZG.didICheckNextVillage == true) {

			if (ZG.didCubeGotIntoTownOnce == true) {
				ImageMapVillage.SetActive (true);
				ImageMapZoneVillage.SetActive (false);
			} else {
				BigArea.SetActive (true);
				ImageMapZoneVillage.SetActive (true);
			}
		}

		if (ZG.didICheckSmallThing == true) {

			if (ZG.didCubeGotInSmallOnce == true) {
				ImageMapSmall.SetActive (true);
				ImageMapZoneSmall.SetActive (false);
			} else {
				SmallArea.SetActive (true);
				ImageMapZoneSmall.SetActive (true);
			}
		}	
	}
}
