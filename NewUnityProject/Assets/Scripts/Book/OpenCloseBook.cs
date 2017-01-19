using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ThirdPersonCamera
{
public class OpenCloseBook : MonoBehaviour {

	public GameObject canvas;
	public GameObject cameraMiniMap;
	public bool isBookOpen;
	public GameObject buttonOuvrirBook;

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
			buttonOuvrirBook.SetActive (false);
			isBookOpen = false;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().enabled = false;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().enabled = false;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().v = 0;
			player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().h = 0;

				//FF.lockMouseCursor = false;
		} else 
			if (Input.GetButtonDown ("Cancel") && !isBookOpen) {
				buttonOuvrirBook.SetActive (true);
				canvas.SetActive (false);
				cameraMiniMap.SetActive (false);
				isBookOpen = true;
				player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ().enabled = true;
				player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().enabled = true;

				//FF.lockMouseCursor = true;
		}
	}
	}
}
