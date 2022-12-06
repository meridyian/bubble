using UnityEngine.SceneManagement;
using UnityEngine;
using Scene = UnityEditor.SearchService.Scene;

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
    
    //instead of getting just reference for collided object, also took some more info
    void OnCollisionEnter2D(Collision2D col)
    
    {
        if (col.collider.tag == "Ball")
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
