using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour 
{
	public GameObject bulletPrefab;

    //Speed of the bullet spawn rate. Can be changed in the inspector.
    public float spawnRateInSeconds = 0.1f;

    //Add the Fire() method to the event listener.
	private void OnEnable()
	{
		Managers.EventManager.OnMouseDownAction += Fire;
	}

    //Remove the Fire() method from the event listener.
	private void OnDisable()
	{
		Managers.EventManager.OnMouseDownAction -= Fire;
	}

	private void Fire()
	{
		StartCoroutine(FireBullets());
	}

	private IEnumerator FireBullets()
	{
		float counter = 0.0f;

        //Continue to fire while the mouse is held down.
		while (Input.GetMouseButton(0))
		{
			counter += Time.deltaTime;

            //Increment the spawnrate counter and if we reach the spawnrate...
			if (counter >= spawnRateInSeconds)
			{
				counter = 0;

				//... then fire!
				GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
				Bullet bulletScript = bullet.GetComponent<Bullet>();
				bulletScript.ObjRigidbody.velocity = transform.parent.forward * bulletScript.bulletSpeed;
			}

			yield return null;
		}
	}
}
