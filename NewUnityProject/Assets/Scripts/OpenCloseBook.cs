using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ThirdPersonCamera
{
public class OpenCloseBook : MonoBehaviour {

	public GameObject canvas;
	public bool isBookOpen;

	public FreeForm FF;

	public GameObject player;

	// Use this for initialization
	void Start () {
		canvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("OpenBook") && isBookOpen) {
				canvas.SetActive (true);
			isBookOpen = false;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().enabled = false;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().enabled = false;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().v = 0;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().h = 0;

				//FF.lockMouseCursor = false;
		} else 
			if (Input.GetButtonDown ("Cancel") && !isBookOpen) {
					
				canvas.SetActive (false);
				isBookOpen = true;
				player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().enabled = true;
				player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().enabled = true;

				//FF.lockMouseCursor = true;
		}
	}
	}
}
