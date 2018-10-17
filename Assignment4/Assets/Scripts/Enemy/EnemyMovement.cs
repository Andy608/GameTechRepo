using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour 
{
	public GameObject target;

    //Speed at which to move towards the target.
	public float movspeed = 10.0f;
    public float rotSpeed = 10.0f;

    public float targetRadius = 5.0f;

    private Vector3 distance;

    private Vector3 velocity = new Vector3();
    private Vector3 direction;

	private void Update()
	{
        distance = target.transform.position - transform.position;

        if (target && distance.sqrMagnitude > targetRadius * targetRadius)
		{
            //Move towards the target as long as the target is not null.
            velocity = distance;
        }
        else
        {
            velocity *= 0.9f;

            if (velocity.magnitude < 0.1f)
            {
                velocity = Vector3.zero;
            }
        }

        direction = distance;
        direction.y = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
    }

    public float GetSpeed()
    {
        return velocity.magnitude;
    }
}
