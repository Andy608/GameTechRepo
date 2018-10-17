using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float currentRotationSpeed = 0;

    //Used to clamp the camera pitch.
    public float minPitch = -89;
    public float maxPitch = 89;

    private float cameraPitch = 0;

    private Transform cameraTransform;

    private void Start()
    {
        cameraTransform = transform;
    }

    private void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * currentRotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * currentRotationSpeed;

        Vector3 rotation = cameraTransform.localRotation.eulerAngles;

        //Invert the mouse so as the mouse moves up, the camera rotates up and vice versa.
        cameraPitch -= mouseY;

        //Constrain the pitch so the camera doesn't go upside down or in the floor.
        cameraPitch = Mathf.Clamp(cameraPitch, minPitch, maxPitch);

        //We want to rotate only the camera when dealing with x axis rotation.
        cameraTransform.localRotation = Quaternion.Euler(cameraPitch, cameraTransform.localRotation.y, cameraTransform.localRotation.z);

        //We want to rotate the camera and player when dealing with y axis rotation.
        cameraTransform.parent.Rotate(0, mouseX, 0);
    }
}
