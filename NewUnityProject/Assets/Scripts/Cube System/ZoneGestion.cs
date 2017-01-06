using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneGestion : MonoBehaviour {

	//list searching in between actual transform of area and stuff

	GameObject Player;

	public GameObject[] ListDeZone;

	public bool AmIInsideArea;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
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
	}
}
