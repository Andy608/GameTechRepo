using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour 
{
	private void OnEnable()
	{
		Managers.EventManager.OnSpaceDownAction += OnGameStartRequested;
		Managers.GameStateManager.Instance.CurrentState = EnumGameState.TITLE_WAITING;
	}

	private void OnDisable()
	{
		Managers.EventManager.OnSpaceDownAction -= OnGameStartRequested;
	}
	
	private void OnGameStartRequested()
	{
		if (Managers.GameStateManager.Instance.CurrentState == EnumGameState.TITLE_WAITING)
		{
			Managers.GameStateManager.Instance.CurrentState = EnumGameState.GAME_PLAYING;

			//Remove title panel
			//Reset enemies
			//Go back to normal camera
			Debug.Log("START GAME");
		}
	}
}
