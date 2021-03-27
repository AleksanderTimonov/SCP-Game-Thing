using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnPlayer : MonoBehaviour
{

    KeyCode upKey;
    [SerializeField]
    KeyCode downKey;
    [SerializeField]
    KeyCode leftKey;
    [SerializeField]
    KeyCode rightKey;

    


    public void Start()
    {
        upKey = KeyCode.W;
        downKey = KeyCode.S;
        leftKey = KeyCode.A;
        rightKey = KeyCode.D;
    }



    // Check if keys are pressed, if so, rotate...
    void FixedUpdate()
    {

        var isDead = this.GetComponentInParent<playerControl>().isDead;

        if (isDead)
        {
            return;
        }
        if (isDead)
        {
            isDead = true;
            
        }
        else
        {
            isDead = false;
        }

        if (isDead)
        {
            return;
        }
        // NORTH, SOUTH, EAST, & WEST

        // While Moving North
        if (Input.GetKey(upKey)) 
        {
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);

        }

        // While Moving South
        if (Input.GetKey(downKey)) 
        {
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 180);
        }

        // While Moving West
        if (Input.GetKey(leftKey)) 
        {
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 90);
        }

        // While Moving East
        if (Input.GetKey(rightKey)) 
        {
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -90);
        }

        // DIAGONAL ROTATION

        // While Moving North-West
        if (Input.GetKey(upKey)) 
        {
            if (Input.GetKey(leftKey))
            {
                GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 45);
            }

        }

        // While Moving North-East
        if (Input.GetKey(upKey)) 
        {
            if (Input.GetKey(rightKey))
            {
                GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -45);
            }
        }

        // While Moving South-West
        if (Input.GetKey(downKey)) 
        {
            if (Input.GetKey(leftKey))
            {
                GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 135);
            }
        }
        // While Moving South-East
        if (Input.GetKey(downKey)) 
        {
            if (Input.GetKey(rightKey))
            {
                GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -135);
            }
        }




    }
}


