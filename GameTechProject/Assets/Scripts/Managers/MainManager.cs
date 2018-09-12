using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class MainManager : Singleton<MainManager>
    {
        //Used to determine what to display in the End Sceen UI Panel.
        public enum EndType
        {
            WIN,
            LOSE
        };

        public bool debugMode = false;

        private EndType endType;

        private GameObject playerObj;
        private GameObject tankObj;

        void Start()
        {
            playerObj = GameObject.Find("Player");
            tankObj = GameObject.Find("Tank");
        }

        //Returns the end type for the game - Either win or lose for now.
        public EndType GetEndType()
        {
            return endType;
        }

        //Hide the cursor.
        //Hides the ending UI and restarts the game.
        public void StartGame()
        {
            Cursor.visible = false;
            Managers.UiManager.Instance.HideEndSceneUI();
            SceneManager.LoadScene("SampleScene");
        }

        //Show the cursor.
        //Disable important game objects.
        //Shows the ending UI depending on the win state.
        public void EndGame(EndType type)
        {
            endType = type;
            Cursor.visible = true;
            tankObj.SetActive(false);
            playerObj.GetComponent<PlayerMovement>().enabled = false;
            playerObj.GetComponentInChildren<ThirdPersonCamera>().enabled = false;
            Managers.UiManager.Instance.ShowEndSceneUI();
        }
    }
}


