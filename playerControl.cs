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
    KeyCode upArrow;
    [SerializeField]
    KeyCode downArrow;
    [SerializeField]
    KeyCode leftArrow;
    [SerializeField]
    KeyCode rightArrow;

    public void Start()
    {
        verticalMovement.y = 0.1f;
        horizontalMovement.x = 0.1f;
        upArrow = KeyCode.UpArrow;
        downArrow = KeyCode.DownArrow;
        leftArrow = KeyCode.LeftArrow;
        rightArrow = KeyCode.RightArrow;
    }

    void FixedUpdate()
    {

        
        if (Input.GetKey(upArrow)) // NORTH
        {
            GetComponent<Transform>().position += new Vector3(0, verticalMovement.y, 0);


        }
        if (Input.GetKey(downArrow)) //SOUTH
        {
            GetComponent<Transform>().position -= new Vector3(0, verticalMovement.y, 0);

        }

        if (Input.GetKey(leftArrow)) // WEST
        {
            GetComponent<Transform>().position -= new Vector3(horizontalMovement.x, 0, 0);

        }

        if (Input.GetKey(rightArrow)) //EAST
        {
            GetComponent<Transform>().position += new Vector3(horizontalMovement.x, 0, 0);

        }




    }
}
