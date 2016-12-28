using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zonedetection : MonoBehaviour {

	public bool areWeInTheZone;
	public bool didWeAllreadyScan;

	Text FullDescription;
	Text XVertical;
	Text XHorizontal;

	Animator PlayNewEntryAnim;
	Animator AllreadyScannedAnim;

	// Use this for initialization
	void Start () {

		PlayNewEntryAnim = GameObject.Find ("Panel New Map Info Scan").GetComponent<Animator>();
		AllreadyScannedAnim = GameObject.Find ("Panel New Map Info Scanned").GetComponent<Animator>();

		FullDescription = GameObject.Find ("TextFullTextDescription").GetComponent<Text>();
		XVertical = GameObject.Find ("TextPetitVertical").GetComponent<Text>();
		XHorizontal = GameObject.Find ("TextPetitHorizontal").GetComponent<Text>();

		//if(firstTimePlaying){}
		XVertical.text = "0 V";
		XHorizontal.text = "0 H";
		FullDescription.text = "Use the cube pressing E to scan"; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeText (){

		if (areWeInTheZone) {
		
			//dosome

		} else {
			
			if (didWeAllreadyScan) {
				
				FullDescription.text = "New Entry 2 Vertical 3 Horizontal New area to explore, allready scanned"; 
				AllreadyScannedAnim.Play ("NewObjectiveUIActivation");
			} else {
				XVertical.text = "5 V";
				XHorizontal.text = "3 H";
				FullDescription.text = "New Entry 2 Vertical 3 Horizontal New area to explore"; 
				PlayNewEntryAnim.Play ("NewObjectiveUIActivation");
				didWeAllreadyScan = true;
			}
		}
	}
}
