using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation(){
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
	//	PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName); 
		PlayerPrefs.SetInt ("CURRENTXP", GameInformation.CurrentXP);
		PlayerPrefs.SetInt ("NEEDEDXP", GameInformation.NeededXP);
		PlayerPrefs.SetInt ("STAMINA", GameInformation.Stamina);
		PlayerPrefs.SetInt ("STRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt ("INTELLECT", GameInformation.Intellect);
		PlayerPrefs.SetInt ("MIND", GameInformation.Mind);
		PlayerPrefs.SetInt ("WISDOM", GameInformation.Wisdom);
		PlayerPrefs.SetInt ("FIRERESISTANCE", GameInformation.FireResistance);
		PlayerPrefs.SetInt ("WATERRESISTANCE", GameInformation.WaterResistance);
		PlayerPrefs.SetInt ("AIRRESISTANCE", GameInformation.AirResistance);
		PlayerPrefs.SetInt ("EARTHRESISTANCE", GameInformation.EarthResistance);
		PlayerPrefs.SetInt ("GOLD", GameInformation.Gold);

//		if (GameInformation.EquipmentOne != null) {
//			PPSerialization.Save ("EQUIPMENTITEM1", GameInformation.EquipmentOne);
//		}

			Debug.Log ("SAVED");
		}
	}