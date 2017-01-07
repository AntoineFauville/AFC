using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneGestion : MonoBehaviour {

	//list searching in between actual transform of area and stuff

	GameObject Player;

	//bool scan

	public bool didICheckNextVillage;
	public bool isThereSomthingAround;
	public bool didICheckSmallThing;

	public bool cubeIsHereInTown;
	public bool resoudreLEnigme;

	public bool cubeIsHereSmall;

	public bool didCubeGotIntoTownOnce;
	public bool didCubeGotInSmallOnce;

	GameObject ScanningFeedBack01;
	GameObject ScanningFeedBack02;
	GameObject ScanningFeedBack03;

	public GameObject[] ListDeZone;

	public GameObject[] SmallObject;

	public bool AmIInsideArea;

	//animation

	public Animator animVillage;
	bool animBoolVillage;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		ScanningFeedBack01 = GameObject.Find ("PanelNewMapInfoScan");
		ScanningFeedBack02 = GameObject.Find ("PanelNewMapInfoScanned");
		ScanningFeedBack03 = GameObject.Find ("PanelNewMapInfoScannedSmall");

		ScanningFeedBack01.SetActive (true);
		ScanningFeedBack02.SetActive (false);
		ScanningFeedBack03.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		animVillage.SetBool ("AnimVillageBool", animBoolVillage);
		//distance face au village

		float distance = Vector3.Distance(Player.transform.position, ListDeZone[0].transform.position);
		//inside area

		if (!cubeIsHereInTown) {

			if (distance < 50) {
				//print ("IN");
				AmIInsideArea = true;
			}
			//outside area
			if (distance >= 50) {
				//print ("OUT"); 
				AmIInsideArea = false;
			}

		} else if (cubeIsHereInTown) {
			
			//launch animation du village
			//bloquer le cube, destroy + faire spawn le village
			//add 1 to list des endroits à visiter.$
			//une fois résolue -> resoudreLEnigme = true;
			didCubeGotIntoTownOnce = true;
			animBoolVillage = true;
			StartCoroutine ("returnBoolAnim");
			cubeIsHereInTown = false;
		}

		//distance face a un petit objet
		float distanceToSmallObject = Vector3.Distance(Player.transform.position, SmallObject[0].transform.position);

		if (!cubeIsHereSmall) {
			if (distanceToSmallObject < 20) {
				isThereSomthingAround = true;
			} else {
				isThereSomthingAround = false;
			}
		} else if (cubeIsHereSmall) {
			didCubeGotInSmallOnce = true;
			cubeIsHereSmall = false;
		}


		//scanning
		if (!didICheckNextVillage) {
			ScanningFeedBack01.SetActive (true);
			ScanningFeedBack02.SetActive (false);
			ScanningFeedBack03.SetActive (false);
		} else {
			if(!didICheckSmallThing && isThereSomthingAround){
				ScanningFeedBack01.SetActive (false);
				ScanningFeedBack02.SetActive (false);
				ScanningFeedBack03.SetActive (true);
			} else {
				ScanningFeedBack01.SetActive (false);
				ScanningFeedBack02.SetActive (true);
				ScanningFeedBack03.SetActive (false);
			}
		}
	}

	public void scanning(){
		//new village found
		// 3 états différents

		// 1 new village found - osef si y a des petits trucs pas loin prio village
		// si j'appuie sur scan ca lance le scan
		if (!didICheckNextVillage) {
			StartCoroutine ("timeOfAnimDetect");
		}

		// 2 new small thing on the map
		 
		if (isThereSomthingAround && didICheckNextVillage && !didICheckSmallThing) {
			StartCoroutine ("timeOfAnimDetect02");
		}
	}

	IEnumerator timeOfAnimDetect () {
		yield return new WaitForSeconds (1.0f);
		didICheckNextVillage = true;

		//A LANCER ICI LORSQU4ON A D2TETCER le village on relance en mettant didICheckNextVillage en, faux.
	}

	IEnumerator timeOfAnimDetect02 () {
		yield return new WaitForSeconds (1.0f);
		didICheckSmallThing = true;

		//A LANCER ICI LORSQU4ON A D2TETCER le smalltruc on relance en mettant didICheckSmallThing en, faux.
	}


	IEnumerator returnBoolAnim () {
		yield return new WaitForSeconds (0.5f);
		animBoolVillage = false;
	}
}
