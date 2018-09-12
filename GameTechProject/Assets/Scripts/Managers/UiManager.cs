using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
	public class UiManager : Singleton <UiManager>
	{
		private Text textField_Coins;

		void Start()
		{
			textField_Coins = GameObject.Find("TextField_Coins").GetComponent<Text>();
		}

		//When the PlayerManager increases the player's coin inventory, it will call this method
		//Notice how this UI element (text field) is NOT updated every frame through Update(), as it only needs to change when the coin value is modified.
		public void UpdateCoinUi(int currentCoins)
		{ 
			//The currentCoins variable (INT) needs to be converted to string in order to display it as text in a UI Text Field.
			textField_Coins.text = ("Coins: " + currentCoins.ToString());
		}
	}
}
