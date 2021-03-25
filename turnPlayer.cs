using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnPlayer : MonoBehaviour
{

    KeyCode upArrow;
    [SerializeField]
    KeyCode downArrow;
    [SerializeField]
    KeyCode leftArrow;
    [SerializeField]
    KeyCode rightArrow;

    public void Start()
    {

        upArrow = KeyCode.UpArrow;
        downArrow = KeyCode.DownArrow;
        leftArrow = KeyCode.LeftArrow;
        rightArrow = KeyCode.RightArrow;

    }
    // Check if keys are pressed, if so, rotate...
    void FixedUpdate()
    {

        // NORTH, SOUTH, EAST, & WEST

        // While Moving North
        if (Input.GetKey(upArrow)) 
        {
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);

        }

        // While Moving South
        if (Input.GetKey(downArrow)) 
        {
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 180);
        }

        // While Moving West
        if (Input.GetKey(leftArrow)) 
        {
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 90);
        }

        // While Moving East
        if (Input.GetKey(rightArrow)) 
        {
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -90);
        }

        // DIAGONAL ROTATION

        // While Moving North-West
        if (Input.GetKey(upArrow)) 
        {
            if (Input.GetKey(leftArrow))
            {
                GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 45);
            }

        }

        // While Moving North-East
        if (Input.GetKey(upArrow)) 
        {
            if (Input.GetKey(rightArrow))
            {
                GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -45);
            }
        }

        // While Moving South-West
        if (Input.GetKey(downArrow)) 
        {
            if (Input.GetKey(leftArrow))
            {
                GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 135);
            }
        }
        // While Moving South-East
        if (Input.GetKey(downArrow)) 
        {
            if (Input.GetKey(rightArrow))
            {
                GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -135);
            }
        }




    }
}


