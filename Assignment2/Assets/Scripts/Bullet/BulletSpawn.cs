using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour 
{
	public GameObject bulletPrefab;

	public float spawnRateInSeconds = 0.1f;

	private void OnEnable()
	{
		Managers.EventManager.OnMouseDownAction += Fire;
	}

	private void OnDisable()
	{
		Managers.EventManager.OnMouseDownAction -= Fire;
	}

	// private void Update()
	// {
	// 	counter += Time.deltaTime;

	// 	if (counter >= spawnRateInSeconds)
	// 	{
	// 		counter = 0;

	// 		if (Input.GetMouseButton(0))
	// 		{
	// 			//Fire!


	// 		}
	// 	}
	// }

	private void Fire()
	{
		StartCoroutine(FireBullets());
	}

	private IEnumerator FireBullets()
	{
		float counter = 0.0f;

		while (Input.GetMouseButton(0))
		{
			counter += Time.deltaTime;

			if (counter >= spawnRateInSeconds)
			{
				counter = 0;
				//Fire!

				GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
				Bullet bulletScript = bullet.GetComponent<Bullet>();
				bulletScript.ObjRigidbody.velocity = transform.parent.forward * bulletScript.bulletSpeed;
			}

			yield return null;
		}
	}
}
