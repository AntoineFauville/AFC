using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour {

	public float moveSpeed = 25.0f;
	public float moveTurnSpeed = 3.0f;
	float m_RunCycleLegOffset = 0.2f;
	float m_StationaryTurnSpeed = 18;
	//public float underwaterSpeed = 10.0f;
	//public bool isUnderwaterD = false;
	//public bool isDrowningD = false;

	GameObject MainCamera;
	private Vector3 VectorCamera;

	//private float PosY;
	private Vector3 velocity;
	public Rigidbody rigidbody;
	public CapsuleCollider collider;

	//private bool IsGrounded = true ;

	IComparer rayHitComparer;

	/*private float jumpPower = 30;
	public float jumpCooldown = 0;
	public bool jump;
	private float distance = 1;*/

	//public bool IsOut;

	/*public Scrollbar Water;
	public GameObject WaterBar;
	public float Air = 1f;*/

	Animator animator;

	float m_TurnAmount;
	float m_ForwardAmount;
	float translation;
	float rotation;
	float MovingRotation;

	float angleY;

	void Start()
	{
		animator = GetComponent<Animator>();
		MainCamera = GameObject.Find ("Main Camera Main");
		//PosY = this.transform.position.y;
		//WaterBar.SetActive (false);
	}

	void FixedUpdate() 
	{
		float v = Input.GetAxis("Vertical");


		if (Input.GetAxis ("Vertical") > 0) {
			translation = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;
			m_TurnAmount = Mathf.Atan2 (0, 0);
			MovingRotation = moveTurnSpeed * Input.GetAxis ("Vertical");
		} else {
			translation = 0.0f;
			MovingRotation = moveTurnSpeed * 2;
			m_TurnAmount = Mathf.Atan2(rotation,rotation);
		}
		//si la camera a un angle different et qu'on appuie sur vertical 

		float actualXCam = MainCamera.transform.rotation.eulerAngles.x;
		float actualYCam = MainCamera.transform.rotation.eulerAngles.y;
		float actualZCam = MainCamera.transform.rotation.eulerAngles.z;

		float actualXPla = transform.rotation.eulerAngles.x;
		float actualYPla = transform.rotation.eulerAngles.y;
		float actualZPla = transform.rotation.eulerAngles.z;

		MainCamera.transform.rotation = Quaternion.Euler (actualXCam,actualYCam,actualZCam);
		transform.rotation = Quaternion.Euler (actualXPla,actualYPla,actualZPla);


		//float axeDeDirection = MainCamera.transform.rotation.eulerAngles.y;
		//float axeDeDirectionJoueur = transform.rotation.eulerAngles.y;

		if(Input.GetAxis ("Vertical") > 0 && MainCamera.transform.rotation.eulerAngles.y != transform.rotation.eulerAngles.y && Input.GetAxis ("Horizontal") == 0)
		{
			transform.rotation = Quaternion.Euler (actualXPla,actualYCam,actualZPla);
		} 

		//angleY = (axeDeDirection.y / (Mathf.Sqrt(1-axeDeDirection.w * axeDeDirection.w)));
		//print (angleY);

		//angleY = 2 * Mathf.Acos (axeDeDirection.y);

		//print("sinY " + Mathf.Asin (axeDeDirectionJoueur.y) * 100);
		//print("cosY " + Mathf.Acos (axeDeDirectionJoueur.y) * 100);
		//print ( transform.rotation.eulerAngles.y);


		//print(MainCamera.transform.rotation);
		//print(transform.rotation);

		rotation = Input.GetAxis ("Horizontal") * MovingRotation * Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);

	/*	if (VectorCamera != null) {
			VectorCamera = Vector3.Scale(MainCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
		}*/


		m_ForwardAmount = translation;

		animator.SetFloat("Forward", m_ForwardAmount*50, 0.1f, Time.deltaTime);
		animator.SetFloat("Turn", m_TurnAmount, 0.1f, Time.deltaTime);

		float runCycle =
			Mathf.Repeat(
				animator.GetCurrentAnimatorStateInfo(0).normalizedTime + m_RunCycleLegOffset, 1);

		/*float turnSpeed = Mathf.Lerp(m_StationaryTurnSpeed, moveTurnSpeed, m_ForwardAmount);
		transform.Rotate(0, m_TurnAmount * turnSpeed * Time.deltaTime, 0);*/

		//UnderWaterSwimming();

		animator.SetFloat("Forward",v);
		/*animator.SetBool("Swim",isUnderwaterD);
		animator.SetBool ("Jumped", IsGrounded);
		animator.SetBool ("Weapon", IsOut);*/

		velocity = rigidbody.velocity;

		/*if (Time.deltaTime > 0)
		{
			Vector3 x = (animator.deltaPosition * moveSpeed) / Time.deltaTime;

			// we preserve the existing y part of the current velocity.
			x.y = GameObject.Find("Player").GetComponent<Rigidbody>().velocity.y;
			GameObject.Find("Player").GetComponent<Rigidbody>().velocity = x;
		}*/

		/*if (Input.GetButton("Jump") /*&& jumpCooldown < Time.time*/ /* && IsGrounded) {
		
			jump = true;
		}*/

		/*if (jump */ /*&& (jumpCooldown < Time.time*/  /* && IsGrounded && isUnderwaterD == false)
		{
			velocity.y = jumpPower; //new Vector3(rigidbody.velocity.x, rigidbody.velocity.y + jumpPower, rigidbody.velocity.z);
			IsGrounded = false;
			jumpCooldown = Time.time + 1f;
			jump = false; 
		}*/

		/*Ray ray = new Ray(transform.position, -transform.up);
		RaycastHit[] hits = Physics.RaycastAll(ray, distance);

		if (Physics.Raycast (ray,distance)) {
		
			foreach (var hit in hits)
			{
				if (!hit.collider.isTrigger)
				{
					IsGrounded = true;
				}
			}
		}*/

		//rigidbody.velocity = velocity;

		/*if (Input.GetKeyDown ("a")) { // Aussi Si ciblage ennemi.

			StartCoroutine(WeaponOut());
		}*/

	}

	/*void UnderWaterSwimming(){
		if (isUnderwaterD) {
			float translationup = Input.GetAxis ("Topdown") * underwaterSpeed * Time.deltaTime;
			transform.Translate (0, translationup, 0);
		}
		if (isDrowningD) {
			WaterBar.SetActive(true);
			print(Air);
			if (Air > 0){
				Air =Air - (Time.time/20000);
				Water.size= Air;
			}
			if (Air <= 0){
				UI_Cara.CurrentStamina = 0;
			}
		}
		if (!isDrowningD) {
			if (Air < 1){
				Air = Air + (Time.time/20000);
				Water.size= Air;
			}
			if (Air >= 1){
				WaterBar.SetActive(false);
			}
		}
	}*/

	/* IEnumerator WeaponOut() {

		IsOut = true;
		yield return new WaitForSeconds (0.5f);
		IsOut = false;
	}

	public void CallCoroutine() {
	
		StartCoroutine (WeaponOut ());
	}
*/
}