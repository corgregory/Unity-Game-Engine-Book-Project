using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    /*This Script is for the sphere collider of the Enemy object
     * and how it responds to a collision with the Player object*/

    // The OnTriggerEnter function will be called when an object
    // enters the enemy's sphere collider radius.
    private void OnTriggerEnter(Collider other)
    {
        // use "other in an if statement to check if the colliding
        // object is the Player object
        if (other.name == "Player")
        
       {
            Debug.Log("Player Detected...ATTACK!");
        }
    }

    // The OnTriggerExit method will be called when an object (Player)
    // leaves the sphere collider radius.

    private void OnTriggerExit(Collider other)
    {
        // this if statement uses "other" to check if the name of the colliding
        // object is "Player"
        if (other.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        
        }
    }

}
