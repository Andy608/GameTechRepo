using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour 
{
	public GameObject target;

	public float speed = 10.0f;

	private void Update()
	{
		if (target)
		{
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
		}
	}
}
