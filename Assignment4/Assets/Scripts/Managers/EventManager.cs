using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
	public class EventManager : Singleton<EventManager>
	{
        //Responsible for keeping track of mouse down actions.
		public delegate void MouseDownAction();
		public static event MouseDownAction OnMouseDownAction;

		private void Update()
		{
            //If the mouse button is clicked, fire the MouseDownAction event.
			if (Input.GetMouseButtonDown(0))
			{
				if (OnMouseDownAction != null)
				{
					OnMouseDownAction();
				}
			}
            else if (Input.GetKey(KeyCode.Space) && SceneManager.GetActiveScene().name == "Title")
            {
                SceneManager.LoadScene("Level");
            }
		}
	}
}
