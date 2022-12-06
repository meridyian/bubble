using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //to give starting force
    public Vector2 startForce;
    public Rigidbody2D rb;
    public GameObject nextball;
    void Start()
    {

        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    public void Split()
    {
        if (nextball != null)
        {
            //transofrm.position always gives z axis
            GameObject ball1 = Instantiate(nextball, rb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject ball2 = Instantiate(nextball, rb.position + Vector2.left/ 4f, Quaternion.identity);
            
            // 
            ball1.GetComponent<Ball>().startForce = new Vector2(2f, 5f);
            ball2.GetComponent<Ball>().startForce = new Vector2(-2f, 5f);
        }
        Destroy(gameObject);
    }
}
