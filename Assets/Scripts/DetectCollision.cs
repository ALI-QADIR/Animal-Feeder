using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   
    // When the animal collides with the projectile
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);    // Destroy the animal
        Destroy(other.gameObject);  // Destroy the projectile
    }
}
