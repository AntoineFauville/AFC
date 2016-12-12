using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuGestion : MonoBehaviour {

	public bool amILaunched = false;
	public CanvasGroup imageblanche;

	public bool state1, state2;

	public GameObject state1Outline;
	public GameObject state2Outline;

	public float amoutOfAlpha;

	private float amoutofsecInput = 0.6f;
	private bool canIInputAgain;

	private bool didIPess = false;
	// Use this for initialization
	void Start () {
		state1 = true;
		state2 = false;
		imageblanche.alpha = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (amILaunched) {
			imageblanche.alpha += amoutOfAlpha;
		}

		if(Input.GetAxis("Vertical") >= 0.4f && !canIInputAgain && state1 == false){
			state1 = true;
			state2 = false;
		}
		if(Input.GetAxis("Vertical") <= -0.4f && !canIInputAgain && state1 == true){
			state1 = false;
			state2 = true;
		}

		if (state1){
			state1Outline.SetActive (true);
			state2Outline.SetActive (false);

			if(Input.GetButtonDown("Submit") && !didIPess){
				didIPess = true;
				LoadScene ();
			}
		}
		if (state2){
			state1Outline.SetActive (false);
			state2Outline.SetActive (true);

			if(Input.GetButtonDown("Submit") && !didIPess){
				didIPess = true;
				QuitGame ();
			}
		}

	}

	public void QuitGame(){
		amILaunched = true;
		StartCoroutine ("EndGame");
		Application.CancelQuit ();
	}

	public void LoadScene(){
		amILaunched = true;
		StartCoroutine ("launchGame");
	}

	IEnumerator launchGame (){
		yield return new WaitForSeconds (3.0f);
		SceneManager.LoadScene ("SceneIntroRemasterd");
	}

	IEnumerator EndGame (){
		yield return new WaitForSeconds (3.0f);
		Application.CancelQuit ();
	}

	IEnumerator returnInput (){
		yield return new WaitForSeconds (amoutofsecInput);
		canIInputAgain = false;
	}
}
