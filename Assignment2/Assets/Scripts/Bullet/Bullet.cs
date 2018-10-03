using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour 
{
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
		if (col.gameObject.tag == "Enemy")
		{
			//Damage enemy in a future build.
			Destroy(col.gameObject);
		}

		Destroy(this.gameObject);
	}
}
