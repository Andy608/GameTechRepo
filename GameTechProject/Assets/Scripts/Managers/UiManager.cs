using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
	public class UiManager : Singleton <UiManager>
	{
        private CanvasRenderer panel_EndScreen;
		private Text textField_Coins;
        private Text textField_Title;
        private Text textField_Score;

        void Start()
        {
            //Init all of the variables and set the panel to false so it's not in the way of the game.
            panel_EndScreen = GameObject.Find("Panel_EndScreen").GetComponent<CanvasRenderer>();
            textField_Coins = GameObject.Find("TextField_Coins").GetComponent<Text>();
            textField_Title = GameObject.Find("TextField_Title").GetComponent<Text>();
            textField_Score = GameObject.Find("TextField_Score").GetComponent<Text>();

            panel_EndScreen.gameObject.SetActive(false);
        }

        public void ShowEndSceneUI()
        {
            //Update all of the ui elements and then show the panel to the player.

            if (Managers.MainManager.Instance.GetEndType() == Managers.MainManager.EndType.WIN)
            {
                textField_Title.text = "You Win! :D";
            }
            else
            {
                textField_Title.text = "You Lose :(";
            }

            textField_Score.text = "Score: " + Managers.CoinManager.Instance.totalCollectedCoins.ToString();

            panel_EndScreen.gameObject.SetActive(true);
        }

        public void HideEndSceneUI()
        {
            panel_EndScreen.gameObject.SetActive(false);
        }

        //When the PlayerManager increases the player's coin inventory, it will call this method
        //Notice how this UI element (text field) is NOT updated every frame through Update(), as it only needs to change when the coin value is modified.
        public void UpdateCoinUi(int currentCoins)
		{ 
			//The currentCoins variable (INT) needs to be converted to string in order to display it as text in a UI Text Field.
			textField_Coins.text = ("Coins: " + currentCoins.ToString());
		}

        public void PlayAgain()
        {
            //Hides the panel again and requests the game to restart.
            panel_EndScreen.gameObject.SetActive(false);
            Managers.MainManager.Instance.StartGame();
        }

        public void QuitGame()
        {
            Application.Quit();
        }
	}
}
