using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour {

    //private CharacterController characterController;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
       if(Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
       {
            transform.Translate(Vector3.forward * -speed * Time.deltaTime);
       }

        if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
        {
            transform.Translate(Vector3.back * -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.Translate(Vector3.left * -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.Translate(Vector3.right * -speed * Time.deltaTime);
        }

    }
}
