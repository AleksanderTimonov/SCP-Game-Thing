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

    void FixedUpdate()
    {
        if (Input.GetKey(upArrow))
            GetComponent<Transform>().position += new Vector3(0, verticalMovement.y, 0);

        


    }
}
