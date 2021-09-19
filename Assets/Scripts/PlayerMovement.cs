using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Need to put PlayerCube Rigidbody box in Unity
    public Rigidbody rb;

    public float forwardForce = 1000f;

    public float sidewaysForce = 100f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // Movement is made by adding forces by absolute directions instead of relative position
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // Calls EndGame() when Player falls off the ground
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
