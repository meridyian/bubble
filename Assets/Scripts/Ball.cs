using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //to give starting force
    public Vector2 startForce;
    public Rigidbody2D rb;
    void Start()
    {
        //
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
