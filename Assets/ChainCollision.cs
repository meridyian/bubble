using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        //we have 1 player, 
        Chain.isFired = false;
    }
}
