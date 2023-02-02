using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public variables with tooltips
    [Tooltip("Horizonatal Input")] public float horizontalInput;                             // horizontal input from player
    [Tooltip("In ms^-1")][SerializeField] public float speed = 20f;                          // speed of player
    [Tooltip("In m")][SerializeField] public float xRange = 10f;                             // horizontal range of player
    [Tooltip("Projectile Prefab")][SerializeField] public GameObject projectilePrefab;       // projectile prefab

    // private variables
    private float projectileYOffset = 1.5f;                                                  // Y axis offset of projectile from player

    // function to move player
    void MovePlayer()
    {
        // Move the player left and right
        horizontalInput = Input.GetAxis("Horizontal");                                      // get horizontal input from player
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);      // move player
        // Keep the player in bounds
        if (transform.position.x < -xRange)                                                 // if player is out of bounds, move back into bounds
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)                                                  // if player is out of bounds, move back into bounds
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    // function to launch projectile
    void LaunchProjectile()
    {
        // if space is pressed, launch a projectile from the player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // instantiate projectile at player position with an offset in the y direction
            Instantiate(projectilePrefab, transform.position + new Vector3(0, projectileYOffset, 0), projectilePrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        LaunchProjectile();
    }
}
