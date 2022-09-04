using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    
    void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if ( Input.GetKey("d"))
        {
            rb.AddForce(0, 0, - sidewayForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sidewayForce * Time.deltaTime);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
