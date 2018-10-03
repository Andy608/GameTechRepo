using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour 
{
	public GameObject target;

    //Speed at which to move towards the target.
	public float speed = 10.0f;

	private void Update()
	{
		if (target)
		{
            //Move towards the target as long as the target is not null.
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
		}
	}
}
