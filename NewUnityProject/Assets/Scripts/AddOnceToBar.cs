using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddOnceToBar : MonoBehaviour {

	public float amoutGainByThisObject;

	public Image refImage;
	public bool didIAllreadyAteHistory;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider coll) {
		if (coll.tag == "Player" && !didIAllreadyAteHistory) {
			didIAllreadyAteHistory = true;
			refImage.fillAmount += amoutGainByThisObject;
		}
	}
}