using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	//Use HEADERS to neatly organize public variables in the Unity's Inspector Window
	[Header("Player Movement Modifiers")]
	public float currentMoveSpeed = 0;
	public float currentRotationSpeed = 0;

	[Header("Player Gravity Modifiers")]

	public float jumpForce;
	public float fallForce;

	[Header("Is Player Grounded")]

	public bool isGrounded;

	//////////////////////////////////////

	private Rigidbody thisRigidBody;

	void Start()
	{
		thisRigidBody = this.gameObject.GetComponent<Rigidbody>();
		//Hide the cursor on screen
		Cursor.visible = false;
	}
	
	//Every frame....(Best used for anything not physics related)
	void Update()
	{
		BasicPlayerMove();
		BasicPlayerRotate();
	}

	//Every FIXED frame....(Best used for everything physics related)
	void FixedUpdate()
	{
		BasicPlayerJump();
		BasicPlayerFall();
	}

	//On Update(), check if Player is translating (using Input)
	private void BasicPlayerMove()
	{
		//Get a value (between -1 and 1, on either controller joystick OR WASD)
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * currentMoveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * currentMoveSpeed;

        //Translate the Player accordingly
        transform.Translate(x, 0, z);
	}

	//On Update(), check if Player is rotating (using Input)
	private void BasicPlayerRotate()
	{
		float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * currentRotationSpeed;

		if(mouseX != 0)
		{
			 //Rotate the Player accordingly
			transform.Rotate(0, mouseX, 0);
		}
	}

	//On Fixed Update, check if player can jump, and is jumping
	private void BasicPlayerJump()
	{
		if(isGrounded)
		{
			if(Input.GetButton("Jump"))
			{
				Vector3 jump = new Vector3(0, jumpForce, 0);
				
				// Here, we use a physics transformation by adding a force to our player
				// The type of force applied can be modified using the "ForceMode" argument 
				thisRigidBody.AddForce(jump, ForceMode.Impulse);

				//Depending on the way you determine if the player is grounded (here, only when he collides again with the floor), make sure to set the variable to the
				//correct value, to prevent the player from jumping indefinitely.
				isGrounded = false;
			}
		}
	}

	//Adding feedback to the fall is just one of the many ways to easily improve the gamefeel of our prototype.
	private void BasicPlayerFall()
	{
		if(!isGrounded)
		{
			//You can measure and monitor a Rigidbody's current velocity (positive or negative value) on any axis
			//Debug.Log(thisRigidBody.velocity.y);

			if(thisRigidBody.velocity.y < 0)
			{
				Vector3 fall = new Vector3(0, fallForce, 0);
				thisRigidBody.AddForce(fall, ForceMode.Acceleration);
			}
		}
	}

	private void OnCollisionStay(Collision col)
	{
		if(col.gameObject.tag == "Floor")
			isGrounded = true;
	}
}
