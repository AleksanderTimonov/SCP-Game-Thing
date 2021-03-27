using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool isDead = GetComponentInParent<playerControl>().isDead;


        if (!isDead)
        {
            return;
        }
        if (isDead)
        {
            Color tmp = GetComponent<SpriteRenderer>().color;
            tmp.a = 255f;
            GetComponent<SpriteRenderer>().color = tmp;
        }
    }
}
