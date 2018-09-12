﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//A NAMESPACE is used here, to make sure all our managers are nicely grouped when using the editor's auto-complete
//This makes it much easier to organise classes and keep your code readable on large-scale projects
namespace Managers
{
	//PlayerManager inherits from the SINGLETON class, making it accessible from all other classes and methods.
	//This also makes sure that only a single PlayerManager exists at any given time.
	public class PlayerManager : Singleton <PlayerManager>
	{
		public GameObject thePlayer;

		public int playerHealth = 100;

		//Enemy bullets that collide with this player will call this method
		public void EnemyBulletHitPlayer(int bulletDamage)
		{
			playerHealth -= bulletDamage;

			if(playerHealth <= 0)
				//The player has a limited health pool. 
				PlayerDeath();
		}

        void PlayerDeath()
		{
			//No capsule is eternal.
			Debug.Log("The Player Has Died - Whoops.");
			//Set the Player's reference to NULL to make sure his next apparition (if he or she respawns) can be acquired and refreshed by GetPlayer()
			thePlayer = null;
		}

		//Other classes will use this common method to gather a link to the Player GameObject (instead of each class searching for the PLayer GameObject by name)
		public GameObject GetPlayer()
		{
			//This method will only search for the player by GameObject name (resource intensive, especially in larger scenes) IF it has not already been identified (or reset on PlayerDeath())
			if(thePlayer == null)
				thePlayer = GameObject.FindGameObjectWithTag("Player");

			return thePlayer;
		}		
	}
}
	



