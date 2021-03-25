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

    private void Start()
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

        if (Input.GetKey(upArrow))
            GetComponent<Transform>().position += new Vector3(0, verticalMovement.y, 0);

        if (Input.GetKey(downArrow))
            GetComponent<Transform>().position -= new Vector3(0, verticalMovement.y, 0);

        if (Input.GetKey(leftArrow))
            GetComponent<Transform>().position -= new Vector3(horizontalMovement.x, 0, 0);

        if (Input.GetKey(rightArrow))
            GetComponent<Transform>().position += new Vector3(horizontalMovement.x, 0, 0);




    }
}
