using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    [SerializeField]
    Vector3 horizontalMovement;
    [SerializeField]
    Vector3 verticalMovement;
    [SerializeField]
    KeyCode upKey;
    [SerializeField]
    KeyCode downKey;
    [SerializeField]
    KeyCode leftKey;
    [SerializeField]
    KeyCode rightKey;

    public void Start()
    {
        verticalMovement.y = 0.1f;
        horizontalMovement.x = 0.1f;
        upKey = KeyCode.W;
        downKey = KeyCode.S;
        leftKey = KeyCode.A;
        rightKey = KeyCode.D;
    }

    void FixedUpdate()
    {

        
        if (Input.GetKey(upKey)) // NORTH
        {
            GetComponent<Transform>().position += new Vector3(0, verticalMovement.y, 0);


        }
        if (Input.GetKey(downKey)) //SOUTH
        {
            GetComponent<Transform>().position -= new Vector3(0, verticalMovement.y, 0);

        }

        if (Input.GetKey(leftKey)) // WEST
        {
            GetComponent<Transform>().position -= new Vector3(horizontalMovement.x, 0, 0);

        }

        if (Input.GetKey(rightKey)) //EAST
        {
            GetComponent<Transform>().position += new Vector3(horizontalMovement.x, 0, 0);

        }




    }
}
