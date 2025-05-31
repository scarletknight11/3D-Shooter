using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScript : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedv = 50.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    // Update is called once per frame
    void Update()
    {
        //yaw += speedH * Input.GetAxis("Mouse X");
        //pitch -= speedv * Input.GetAxis("Mouse Y");

        //transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        if (Gamepad.all[0].rightStick.up.isPressed)
        {
            pitch -= speedv * 10 * Time.deltaTime;
            transform.eulerAngles = new Vector3(pitch, 0.0f, 0.0f);
        }

        if (Gamepad.all[0].rightStick.down.isPressed)
        {
            pitch += speedv * 10 * Time.deltaTime;
            transform.eulerAngles = new Vector3(pitch, 0.0f, 0.0f);
        }

        if (Gamepad.all[0].rightStick.left.isPressed)
        {
            yaw -= speedH * 10 * Time.deltaTime;
            transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        }


        if (Gamepad.all[0].rightStick.right.isPressed)
        {
            yaw += speedH * 10 * Time.deltaTime;
            transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        }

    }
}
