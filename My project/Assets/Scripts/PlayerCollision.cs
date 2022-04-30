using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    //Variables
    public PlayerControls movement;
    void OnCollisionEnter (Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
        }
    }
}
