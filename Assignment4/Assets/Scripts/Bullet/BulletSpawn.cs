using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour 
{
	public GameObject bulletPrefab;

    //Speed of the bullet spawn rate. Can be changed in the inspector.
    public float cooldownSeconds = 0.1f;

    private bool isFirstShot = true;
    private float cooldownCounter = 0.0f;

    private Coroutine firing = null;

    //Add the Fire() method to the event listener.
    private void OnEnable()
	{
		Managers.EventManager.OnMouseDownAction += StartFiring;
	}

    //Remove the Fire() method from the event listener.
	private void OnDisable()
	{
		Managers.EventManager.OnMouseDownAction -= StartFiring;
	}

	private void StartFiring()
	{
        if (Managers.GameStateManager.Instance.CurrentState != EnumGameState.GAME_PLAYING)
        {
            return;
        }

        if (firing == null)
        {
            firing = StartCoroutine(FireBullets());
        }
	}

	private IEnumerator FireBullets()
	{
        //Continue to fire while the mouse is held down.
		while (Input.GetMouseButton(0))
		{
            cooldownCounter += Time.deltaTime;

            //Increment the spawnrate counter and if we reach the spawnrate...
            if (isFirstShot)
            {
                isFirstShot = false;
                Fire();
            }

            if (cooldownCounter >= cooldownSeconds)
			{
                cooldownCounter = 0;

                //... then fire!
                Fire();
			}

			yield return null;
		}

        isFirstShot = true;
        firing = null;
	}

    private void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        bulletScript.ObjRigidbody.velocity = transform.parent.forward * bulletScript.bulletSpeed;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.parent.forward, out hit, bulletScript.bulletRange, LayerMask.NameToLayer("Default")))
        {
            if (hit.collider.tag == "Enemy")
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
