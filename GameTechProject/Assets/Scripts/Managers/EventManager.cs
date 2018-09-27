using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
	public class EventManager : Singleton<EventManager>
	{
		public delegate void SampleAction();
		public static event SampleAction OnSampleAction;

		private const float BUTTON_SIZE = 100.0f;

		private void OnGUI()
		{
			if (GUI.Button(new Rect((Screen.width - BUTTON_SIZE) / 2.0f, (Screen.height - BUTTON_SIZE) / 2.0f, BUTTON_SIZE, BUTTON_SIZE), "Hello, World!"))
			{
				//If there are no listeners, then the delegate is null so we need to make sure it isn't null before sending.
				if (OnSampleAction != null)
				{
					OnSampleAction();
				}
			}
		}
	}
}
