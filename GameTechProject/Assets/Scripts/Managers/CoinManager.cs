using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class CoinManager : Singleton<CoinManager>
    {
        public int totalCollectedCoins = 0;
        public GameObject coinsParent;

        void Start()
        {
            coinsParent = GameObject.Find("Coins");
        }

        //Coins the player collects will call this method.
        public void CoinCollected(int thisCoinValue)
        {
            totalCollectedCoins += thisCoinValue;
            Managers.UiManager.Instance.UpdateCoinUi(totalCollectedCoins);

            //If this was the last coin collected, you win!
            //It's 1 and not 0 because we call this method before we destroy the coin.
            //If we destroyed the coin first, then this method wouldn't get called.
            if (coinsParent.transform.childCount == 1)
            {
                //Win state
                Debug.Log("You win!");
            }
        }
    }
}
