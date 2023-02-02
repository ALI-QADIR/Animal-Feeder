using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    // When the animal collides with the projectile
    private void OnTriggerEnter(Collider other)
    {
        // Destroy(gameObject);    // Destroy the animal
        // Destroy(other.gameObject);  // Destroy the projectile

        // get tag of the other object
        string tag = other.gameObject.tag;
        // Debug.Log("Tag of the other object: " + tag);

        // check if the tag is "Projectile"
        if (tag == "Projectile")
        {
            GameManager.IncrementScore();   // Increment the score
            Destroy(gameObject);    // Destroy the animal
            Destroy(other.gameObject);  // Destroy the projectile
        }
        // check if the tag is "Player"
        else if (tag == "Player")
        {
            // Debug.Log("Collision with player");
            Destroy(gameObject);    // Destroy the animal
            // decrement the lives
            GameManager.DecrementLives();
        }
        else if (tag == "Animal")
        {
            // rotate the animal 180 degrees
            transform.Rotate(0, 180, 0);
        }
        else
        {
            Debug.Log("Something else collided with the animal");
        }
    }
}
