using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSystem : MonoBehaviour {

	GameObject Artefact;
	GameObject RespawnEnigme;


	DropCube DC;
	SanityGestion SG;

	public bool EnigmeActiveeMortSystemOn;


	// Use this for initialization
	void Start () {
		DC = GameObject.Find ("Player").GetComponent<DropCube> ();
		SG = GameObject.Find ("Player").GetComponent<SanityGestion> ();
		RespawnEnigme = GameObject.Find ("RespawnEnigmeTotem");
	}
	
	// Update is called once per frame
	void Update () {

		//dans le cas ou je lache par moi meme le cube

		if (DC.isCubeOnGround) {
			Artefact = GameObject.Find ("ArtefactRecherche(Clone)");

			if (SG.sanity <= 0) {
				this.transform.position =  Artefact.transform.position;
			}
		}

		//dans le cas ou je suis dans une énigme

		if (EnigmeActiveeMortSystemOn) {
			if (SG.sanity <= 0) {
				this.transform.position =  RespawnEnigme.transform.position;
			}
		}
	}

	IEnumerator wait () {
		yield return new WaitForSeconds (0.5f);
	}
}
