using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour 
{
    //Speed of the bullet. Can be changed in the inspector.
	public float bulletSpeed = 10.0f;

	private Rigidbody objRigidbody;

	public Rigidbody ObjRigidbody
	{
		get
		{
			return objRigidbody;
		}
	}

	private void Awake()
	{
		objRigidbody = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(Collision col)
	{
        //Delete the enemy if it collides with a bullet.
		if (col.gameObject.tag == "Enemy")
		{
			//Damage enemy in a future build.
			Destroy(col.gameObject);
		}

        //Delete the bullet when it collides with something.
        Destroy(this.gameObject);
	}
}
