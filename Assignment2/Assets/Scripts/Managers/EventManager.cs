using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
	public class EventManager : Singleton<EventManager>
	{
		public delegate void MouseDownAction();
		public static event MouseDownAction OnMouseDownAction;

		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				if (OnMouseDownAction != null)
				{
					OnMouseDownAction();
				}
			}
		}
	}
}
