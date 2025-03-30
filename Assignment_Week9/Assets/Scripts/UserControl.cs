using UnityEngine;

public class UserControl : MonoBehaviour
{   
    private Rigidbody2D rb;
    public DisplayText displayText;
    public float speed = 0.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        displayText = GameObject.Find("Text (TMP)").GetComponent<DisplayText>();
    }    
    void Update()
    {
        speed = GameManagement.instance.playerSpeed;
        
         if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-speed, 0);
        }else if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(speed, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(0, -speed);
        }else{
            rb.linearVelocity = new Vector2(0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "triangle")
        {
            Destroy(collision.gameObject); 
            GameManagement.instance.playerScore += 1;
            GameManagement.instance.playerSpeed += 0.5f;
        }
        if (collision.gameObject.tag == "square")
        {
            Destroy(collision.gameObject); 
            GameManagement.instance.playerScore += 1;
            GameManagement.instance.playerSpeed -= 1f;
        }
    }
}
