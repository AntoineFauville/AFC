using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}

//	public static BaseEquipment EquipmentOne{ get; set; }

	public string PlayerName{ get; set;}
	public static int PlayerLevel{ get; set;}
//	public static BaseCharacterClass PlayerClass{ get; set;}
	public static int Stamina{ get; set;}	
	public static int Strength{ get; set;}
	public static int Mind{ get; set;}
	public static int Wisdom{ get; set;}
	public static int Intellect{ get; set;}
	public static int FireResistance{ get; set;}
	public static int WaterResistance{ get; set;}
	public static int EarthResistance{ get; set;}
	public static int AirResistance{ get; set;}
	public static int CurrentXP{ get; set;}
	public static int NeededXP{ get; set;}
	public static int Gold{ get; set;}
}
