using UnityEngine;
using System.Collections;

public class DetectArea : MonoBehaviour {

	[SerializeField]public bool amIArea1;

	[SerializeField]public Transform reference;
	[SerializeField]public Transform player;

	[SerializeField]public float dist;

	/*void OnTriggerEnter(Collider coll){
		if (coll.tag == "Player") {
			amIArea1 = true;
			print ("Entered");
		}
	}*/

	void OnTriggerExit(Collider coll){
		if (coll.tag == "Player") {
			amIArea1 = false;
		}
	}

	void Update () {
		if (amIArea1) {
			dist = Vector3.Distance (reference.transform.position, player.transform.position);
			//print (dist);
		}

		if (dist >= 25) {
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_AnimSpeedMultiplier = 1.0f;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_MoveSpeedMultiplier = 1.0f;
		}

		if (dist < 25 && dist >= 21) {
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_AnimSpeedMultiplier = 0.8f;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_MoveSpeedMultiplier = 0.8f;
		}

		if (dist < 21 && dist >= 17) {
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_AnimSpeedMultiplier = 0.7f;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_MoveSpeedMultiplier = 0.7f;
		}

		if (dist < 17 && dist >= 15) {
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_AnimSpeedMultiplier = 0.6f;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_MoveSpeedMultiplier = 0.6f;
		}

		if (dist < 15 && dist >= 13) {
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_AnimSpeedMultiplier = 0.5f;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().m_MoveSpeedMultiplier = 0.5f;
		}
	}

	void OnTriggerStay (Collider coll){
		if (coll.tag == "Player") {
			amIArea1 = true;
		}
	}
}
