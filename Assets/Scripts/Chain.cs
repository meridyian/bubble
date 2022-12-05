using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    //to keep it same even if levels change
    public static bool isFired ;
    public Transform player;
    public float speed = 2f;
    void Start()
    {
        isFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(("Fire1")))
        {
            isFired = true;
        }
        if (isFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
        }
        else
        {
            //since pivots are aligned 
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
