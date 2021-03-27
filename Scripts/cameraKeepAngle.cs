using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraKeepAngle : MonoBehaviour
{
    //This script literally just keeps the camera upright

    void FixedUpdate()
    {

        GetComponent<Transform>().rotation = Quaternion.Euler(1, 0, 0);
    }
}
