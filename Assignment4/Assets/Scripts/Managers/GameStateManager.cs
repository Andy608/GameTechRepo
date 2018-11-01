using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnumGameState
{
	TITLE_PLAYING,
	TITLE_WAITING,
	GAME_PLAYING
}

namespace Managers
{
	public class GameStateManager : Singleton<GameStateManager>
	{
		public delegate void GameStateChangeAction(EnumGameState oldState, EnumGameState newState);
		public static event GameStateChangeAction OnGameStateChangeAction;

		private EnumGameState currentState;

		public EnumGameState CurrentState 
		{ 
			get 
			{ 
				return currentState; 
			}
			 
			set 
			{ 
				EnumGameState oldState = currentState;
				currentState = value;
				
				if (OnGameStateChangeAction != null)
				{
					OnGameStateChangeAction(oldState, currentState);
				}
			}
		}

		private void OnEnable()
		{
			CurrentState = EnumGameState.TITLE_PLAYING;
		}
	}
}