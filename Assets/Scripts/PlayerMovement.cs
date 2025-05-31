using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour {

    //private CharacterController characterController;
    public float speed = 2f;
    public float jump = 8f;
    public float groundDistance = 1.09f;
    public GameObject postprocessing;

    Rigidbody rb;
    bool canDoubleJmp;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();  
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundDistance);
    }

    // Update is called once per frame
    void FixedUpdate()
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

        if(Input.GetKey(KeyCode.G))
        {
            postprocessing.SetActive(true);
        }

        if (Input.GetKey(KeyCode.F))
        {
            postprocessing.SetActive(false);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            if(IsGrounded())
            {
                rb.velocity = Vector3.up * jump;
                canDoubleJmp = true;
            }
            else if(canDoubleJmp)
            {
                rb.velocity = Vector3.up * jump;
                canDoubleJmp = false;
            }
        }
    }
}
