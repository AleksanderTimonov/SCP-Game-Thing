using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aliveBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool isDead = GetComponentInParent<playerControl>().isDead;
        Vector3 deathPosition = GetComponent<Transform>().position;




        if (!isDead)
        {
            return;
        }
        if (isDead)
        {
            GetComponent<Transform>().position = new Vector3(deathPosition.x, deathPosition.y, 10);
        }
        else
        {
            return;
        }

    }
}
