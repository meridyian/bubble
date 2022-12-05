using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    //to keep it same even if levels change
    public static bool isFired ;
    public Transform player;
    void Start()
    {
        isFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFired)
        {
            
        }
        else
        {
            //since pivots are aligned 
            transform.position = player.position;
        }
    }
}
