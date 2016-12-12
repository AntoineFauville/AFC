using UnityEngine;
using System.Collections;

public class LoadInformation {

	public static void LoadAllInformation(){
//		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformation.CurrentXP = PlayerPrefs.GetInt ("CURRENTXP");
		GameInformation.NeededXP = PlayerPrefs.GetInt ("NEEDEDXP");
		GameInformation.Stamina = PlayerPrefs.GetInt ("STAMINA");
		GameInformation.Strength = PlayerPrefs.GetInt ("STRENGTH");
		GameInformation.Intellect = PlayerPrefs.GetInt ("INTELLECT");
		GameInformation.Mind = PlayerPrefs.GetInt ("MIND");
		GameInformation.Wisdom = PlayerPrefs.GetInt ("WISDOM");
		GameInformation.FireResistance = PlayerPrefs.GetInt ("FIRERESISTANCE");
		GameInformation.WaterResistance = PlayerPrefs.GetInt ("WATERRESISTANCE");
		GameInformation.AirResistance = PlayerPrefs.GetInt ("AIRRESISTANCE");
		GameInformation.EarthResistance = PlayerPrefs.GetInt ("EARTHRESISTANCE");
		GameInformation.Gold = PlayerPrefs.GetInt ("GOLD");

		if (PlayerPrefs.GetString ("EQUIPMENTITEM1") != null) {
//			GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.Load("EQUIPMENTITEM1");
		}
	}
}