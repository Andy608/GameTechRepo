using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyMovement))]
public class ZombieController : MonoBehaviour
{
    private const string SPEED_ID = "Speed";

    private Animator animator;
    private EnemyMovement movementScript;

    private void Start()
    {
        animator = GetComponent<Animator>();
        movementScript = GetComponent<EnemyMovement>();
    }

    private void Update()
    {
        animator.SetFloat(SPEED_ID, movementScript.GetSpeed());
    }
}
