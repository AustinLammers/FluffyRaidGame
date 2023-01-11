using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float movementSpeed = 1f;
    float xMovement;
    float zMovement;
    GameObject playerCamera;
    float xMouse;
    float yMouse;
    float currX;
    float currY;
    playerAttributes playerOBJ;
    private Inventory inventory;
    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerCamera = transform.Find("Main Camera").gameObject;
        playerOBJ = new playerAttributes();
        // playerCamera = GameObject.Find("Main Camera");

        
    }

    private void Awake()
    {
        inventory = new Inventory();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOBJ.GetPlayerState() == playerAttributes.state.Normal)
        {
            processMovement();
            moveCamera();
        }
    }

    private void processMovement()
    {
        xMovement = Input.GetAxis("Horizontal");
        zMovement = Input.GetAxis("Vertical");
        rb.velocity = transform.TransformDirection(new Vector3(xMovement, rb.velocity.y, zMovement) * movementSpeed);
        //rb.velocity = (new Vector3(xMovement, rb.velocity.y, zMovement) * movementSpeed);
    }

    private void moveCamera()
    {
        xMouse = Input.GetAxisRaw("Mouse X");
        yMouse = Input.GetAxisRaw("Mouse Y");
        print(xMouse + ", " + yMouse);
        currY = (playerCamera.transform.rotation.y);
        currX = (playerCamera.transform.rotation.x);
        playerCamera.transform.Rotate(-yMouse, 0, 0);
        transform.Rotate(0, xMouse, 0);
    }

    private void pickUpItem()
    {


    }
}
