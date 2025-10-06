using UnityEngine;

public class playerCollison : MonoBehaviour
{
    public playerMovement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
