
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody2D rb;
    private float movement = 0f;
    void Update()
    {
        // (-1,1)
        
        movement  = Input.GetAxisRaw("Horizontal") * speed ;
    }

    void FixedUpdate()
    {
        //fixedupdate physics calculated
        //current+movement
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));
        
        
        
    }
}
