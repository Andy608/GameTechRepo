using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour 
{
    public float rotationSpeed = 200.0f;

    //Used to clamp the camera pitch.
    public float minPitch = 0;
    public float maxPitch = 89;

    //Used to clamp the camera zoom.
    public float minZoom = -10;
    public float maxZoom = -4;

    public float cameraPitch = 0;
    public float currentZoom = 0;

    private Vector3 cameraLocalPosition;
    private GameObject thirdPersonCamera;

    private void Start()
    {
        thirdPersonCamera = transform.Find("Main Camera").gameObject;
        cameraLocalPosition = thirdPersonCamera.transform.localPosition;
    }

    void Update()
    {
        RotateCamera();
        ZoomCamera();
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * rotationSpeed;

        Vector3 rotation = transform.localRotation.eulerAngles;

        //Invert the mouse so as the mouse moves up, the camera rotates up and vice versa.
        cameraPitch -= mouseY;

        //Constrain the pitch so the camera doesn't go upside down or in the floor.
        cameraPitch = Mathf.Clamp(cameraPitch, minPitch, maxPitch);

        //We want to rotate only the camera when dealing with x axis rotation.
        transform.localRotation = Quaternion.Euler(cameraPitch, transform.rotation.y, transform.rotation.z);

        //We want to rotate the camera and player when dealing with y axis rotation.
        transform.parent.Rotate(0, mouseX, 0);
    }

    private void ZoomCamera()
    {
        //Add the zoom depending on the direction the mouse wheel is scrolled.
        currentZoom += Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * rotationSpeed;

        //Clamp the zoom if it's out of bounds.
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        //Set the new position for the camera.
        cameraLocalPosition.Set(transform.localPosition.x, transform.localPosition.y, currentZoom);
        thirdPersonCamera.transform.localPosition = cameraLocalPosition;
    }
}
