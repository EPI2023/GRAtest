using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //reference to PlayerMovement script

    //this function runs when we hit another object
    //we get info about the collision and call it "collisionInfo"
   void OnCollisionEnter (Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);

        //we check if the collider has the "Obstacle" tag
        if (collisionInfo.collider.tag=="Obstacle")
        {
            //Debug.Log("We hit an object");

            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}