using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //we have 1 player, 
        Chain.isFired = false;

        if (col.tag == "Ball")
        {
            col.GetComponent<Ball>().Split();
        }
    }
}
