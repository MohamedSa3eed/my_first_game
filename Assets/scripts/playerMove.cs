using UnityEngine;
public class playerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float forwad = 2000f;
    public float side = 500f;
   
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwad * Time.deltaTime);
        if (Input.GetKey("d"))
        { rb.AddForce(side * Time.deltaTime, 0, 0,ForceMode.VelocityChange); }
        if (Input.GetKey("a"))
        { rb.AddForce(-side * Time.deltaTime, 0, 0, ForceMode.VelocityChange); }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
