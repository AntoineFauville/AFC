using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneGestion : MonoBehaviour {

	//list searching in between actual transform of area and stuff

	GameObject Player;

	bool didICheckNextVillage;
	bool isThereSomthingAround;

	GameObject ScanningFeedBack01;
	GameObject ScanningFeedBack02;

	public GameObject[] ListDeZone;

	public bool AmIInsideArea;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		ScanningFeedBack01 = GameObject.Find ("PanelNewMapInfoScan");
		ScanningFeedBack02 = GameObject.Find ("PanelNewMapInfoScanned");

		ScanningFeedBack01.SetActive (true);
		ScanningFeedBack02.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(Player.transform.position, ListDeZone[0].transform.position);
		//inside area
		if(distance < 50){
			print ("IN");
			AmIInsideArea = true;
		}
		//outside area
		if(distance >= 50){
			print ("OUT"); 
			AmIInsideArea = false;
		}



		//scanning


	}

	public void scanning(){
		//new village found

		if (!didICheckNextVillage) {
			//launch Anim 1
			ScanningFeedBack01.SetActive (true);
			ScanningFeedBack02.SetActive (false);

			didICheckNextVillage = true;
			//launch Anim 2
		} else {
			ScanningFeedBack01.SetActive (false);
			ScanningFeedBack02.SetActive (true);
		}

		//nothing around
		if(isThereSomthingAround){
			
		}


		//new thing on the map !!
		/*if(didICheckNextVillage || !isThereSomthingAround){
			ScanningFeedBack01.SetActive (false);
			ScanningFeedBack02.SetActive (true);
		}*/
	}
}
