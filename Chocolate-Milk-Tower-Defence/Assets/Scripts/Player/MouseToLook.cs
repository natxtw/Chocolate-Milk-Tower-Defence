using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseToLook : MonoBehaviour
{
    public float MouseSensitivity = 100.0f;
    public Transform PlayerBody;

    private float xRotation = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //locks the users mouse to the center of the screen
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        //time.delta time is the amount of time that passes by since the last time the update function was called, meaning the player won't rotate quicker if they have higher fps.
        float mouseY = Input.GetAxis("Mouse Y");

        xRotation -= mouseY;
        //Decreasing to prevent the rotation flipping.

        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);
        //Ensures no over rotation from the player

        transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        //Quaternions handle rotations in Unity

        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
