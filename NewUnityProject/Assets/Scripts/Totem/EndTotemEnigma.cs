using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTotemEnigma : MonoBehaviour {

	public GameObject FEEDINFORMATIOOON;
	public GameObject Endcanvas;

	public Quaternion actual1;

	public GameObject TopPart;
	public GameObject MidPart;
	public GameObject DownPart;

	public bool EnigmaIsDone;

	void Start () {
	}

	// Update is called once per frame
	void Update () {

		Quaternion currentRotationPart1 = (TopPart.transform.rotation);
		Quaternion currentRotationPart2 = (MidPart.transform.rotation);
		Quaternion currentRotationPart3 = (DownPart.transform.rotation);

		float rot1 = Mathf.Abs (currentRotationPart1.y); 
		float rot2 = Mathf.Abs (currentRotationPart2.y);
		float rot3 = Mathf.Abs (currentRotationPart3.y);
	
		if (rot1 >= 0.95f && rot1 <= 0.96f &&
			rot2 >= 0.95f && rot2 <= 0.96f &&
			rot3 >= 0.95f && rot3 <= 0.96f) 
		{
			EnigmaIsDone = true;
			Endcanvas.SetActive (true);
			FEEDINFORMATIOOON.SetActive (true);
		}
	}
}
