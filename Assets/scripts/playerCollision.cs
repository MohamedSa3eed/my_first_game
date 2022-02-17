
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMove movement;
    //public gameManager manger;
    public void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
